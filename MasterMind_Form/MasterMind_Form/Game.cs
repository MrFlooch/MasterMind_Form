using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace MasterMind_Form
{
    public partial class Game : Form
    {
        #region Form Variables
        // Defines the length of the code
        public int initCodeLength;
        // Defines the number of colors in the code
        public int initColorLength;
        // Link to the other forms
        private readonly Difficulty difficulty;
        private readonly Menu mainMenu;
        private readonly Options optionsBG;
        // Counter dor the location of the current color
        int currentColumn;
        int currentLine;
        // Counts the number of attempts
        int clickCounter = 0;
        // Specifies the size of rows and columns in the array
        const int ROWS = 10;
        // Allows to check if the colorblind option is currently in use
        bool CBisChecked;
        // Allows to check if the cheat is on
        bool cheater;
        // Initializes the grids to be displayed
        Label[,] colorBtnGrid;
        Label[,] hintBtnGrid;
        readonly Label[] colorsSecretCode;
        Button[] colorBtnInit;
        // Initialyze the jingles of victory or lose
        readonly private SoundPlayer win;
        readonly private SoundPlayer lose;
        readonly private SoundPlayer cheat;

        // Array of colors
        private readonly Color[] codeColors = new Color[] { Color.Green, Color.Yellow, Color.White, Color.Red, Color.Blue, Color.Magenta, Color.Cyan };
        private readonly Color[] CBcodeColors = new Color[] { Color.DarkSeaGreen, Color.Khaki, Color.White, Color.OrangeRed, Color.SteelBlue, Color.Plum, Color.LightSkyBlue };

        // Array of background images
        private readonly Image[] colorsImage = new Image[] { Properties.Resources.green, Properties.Resources.yellow, Properties.Resources.white, Properties.Resources.red, Properties.Resources.blue, Properties.Resources.magenta, Properties.Resources.cyan };
        private readonly Image[] ironColorsImage = new Image[] { Properties.Resources.irongreen, Properties.Resources.ironyellow, Properties.Resources.ironwhite, Properties.Resources.ironred, Properties.Resources.ironblue, Properties.Resources.ironmagenta, Properties.Resources.ironcyan };
        private readonly Image[] neonColorsImage = new Image[] { Properties.Resources.green_neon, Properties.Resources.yellow_neon, Properties.Resources.white_neon, Properties.Resources.red_neon, Properties.Resources.blue_neon, Properties.Resources.magenta_neon, Properties.Resources.cyan_neon };
        private readonly Image[] pokerColorsImage = new Image[] { Properties.Resources.green_poker, Properties.Resources.yellow_poker, Properties.Resources.white_poker, Properties.Resources.red_poker, Properties.Resources.blue_poker, Properties.Resources.magenta_poker, Properties.Resources.cyan_poker };
        private readonly Image[] CBcolorsImage = new Image[] { Properties.Resources.CBgreen, Properties.Resources.CByellow, Properties.Resources.white, Properties.Resources.CBred, Properties.Resources.CBblue, Properties.Resources.CBmagenta, Properties.Resources.CBcyan };
        private readonly Image[] CBironColorsImage = new Image[] { Properties.Resources.iron_CBgreen, Properties.Resources.iron_CByellow, Properties.Resources.ironwhite, Properties.Resources.iron_CBred, Properties.Resources.iron_CBblue, Properties.Resources.iron_CBmagenta, Properties.Resources.iron_CBcyan };
        private readonly Image[] CBpokerColorsImage = new Image[] { Properties.Resources.poker_CBgreen, Properties.Resources.poker_CByellow, Properties.Resources.white_poker, Properties.Resources.poker_CBred, Properties.Resources.poker_CBblue, Properties.Resources.poker_CBmagenta, Properties.Resources.poker_CBcyan };
        private readonly Image[] CBneonColorsImage = new Image[] { Properties.Resources.neon_CBgreen, Properties.Resources.neon_CByellow, Properties.Resources.white_neon, Properties.Resources.neon_CBred, Properties.Resources.neon_CBblue, Properties.Resources.neon_CBmagenta, Properties.Resources.neon_CBcyan };
        #endregion

        #region Form Initialisation
        public Game(Menu menu, Difficulty difficulty, Options options)
        {
            InitializeComponent();

            // Store references to other forms
            this.difficulty = difficulty;
            initCodeLength = difficulty.codeLength;
            initColorLength = difficulty.colorLength;
            mainMenu = menu;
            optionsBG = options;

            // Initialyze the length of the secret code
            colorsSecretCode = new Label[initCodeLength];

            // Hide the code panel initially
            codePnl.Hide();

            // Load sound files for win and lose scenarios
            win = new SoundPlayer(@"..\..\..\..\MasterMind_Audio\bravo.wav");
            lose = new SoundPlayer(@"..\..\..\..\MasterMind_Audio\lose.wav");
            cheat = new SoundPlayer(@"..\..\..\..\MasterMind_Audio\cheat.wav");

            // Set the initial position of the window to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the "Validate" button until the code is fully entered
            validBtn.Enabled = false;

            // Set background image and color based on user options
            foregroundImagePnl.BackgroundImage = optionsBG.GetImageBackground();
            backgroundImagePnl.BackColor = optionsBG.GetColor();

            // Boolean to determine color variation based on color blindness
            CBisChecked = optionsBG.CBisChecked;

            // Boolean to determine if the cheat is on
            cheater = false;

            // Enable the ability to view the code using the 'C' key
            this.KeyPreview = true;

            // Attach the KeyDown event the the C and D keys
            this.KeyDown += CodePnl_KeyDown;

            // Generate the secret code
            GenerateCode();
        }

        /// <summary>
        /// Method to adjust the window size based on the code length
        /// </summary>
        /// <param name="codeLength"></param>
        private void AdjustLayoutBasedOnCodeLength(int codeLength)
        {
            const int BASE_WIDTH = 500;
            int additionalWidth = (codeLength - 4);

            // Adjust the size and location of various controls based on the code length
            this.Size = new Size(BASE_WIDTH + additionalWidth * 80, 800);
            menuBtnPnl.Location = new Point((BASE_WIDTH + additionalWidth * 80) - 240, 635);
            colorPnl.Size = new Size(200 + additionalWidth * 50, 580);
            hintPnl.Size = new Size(125 + additionalWidth * 30, 580);
            hintPnl.Location = new Point(231 + additionalWidth * 50, 20);
            foregroundImagePnl.Size = new Size(460 + additionalWidth * 80, 735);
            backgroundImagePnl.Size = new Size(460 + additionalWidth * 80, 735);
            colorBtnPnl.Location = new Point(380 + additionalWidth * 80, 25);
            gridPnl.Size = new Size(350 + additionalWidth * 80, 670);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // Check if the radiobutton is checked in the "options" form
            bool IsEnglishChecked = optionsBG.IsEnglishChecked;
            bool IsGermanChecked = optionsBG.IsGermanChecked;
            bool IsItalianChecked = optionsBG.IsItalianChecked;

            // Set form text and button texts based on language preference
            if (IsEnglishChecked)
            {
                this.Text = "MasterMind - Game";
                resetBtn.Text = "Reset";
                undoBtn.Text = "Cancel";
                menuBtn.Text = "Menu";
            }
            else if (IsGermanChecked)
            {
                this.Text = "MasterMind - Spiel";
                resetBtn.Text = "Zurücksetzen";
                undoBtn.Text = "Stornieren";
                menuBtn.Text = "Menü";
            }
            else if (IsItalianChecked)
            {
                this.Text = "MasterMind - Gioco";
                resetBtn.Text = "Ripristina";
                undoBtn.Text = "Annulla";
                menuBtn.Text = "Menu";
            }
            else
            {
                this.Text = "MasterMind - Jeu";
                resetBtn.Text = "Réinit.";
                undoBtn.Text = "Annuler";
                menuBtn.Text = "Menu";
            }

            // Adjust UI elements based on the background color
            if (backgroundImagePnl.BackColor == Color.Brown)
            {
                gridPnl.BackgroundImage = Properties.Resources.Grid;
                menuBtn.ForeColor = Color.Black;
                undoBtn.ForeColor = Color.Black;
                resetBtn.ForeColor = Color.Black;
                validBtn.ForeColor = Color.Black;
            }
            else if (backgroundImagePnl.BackColor == Color.Red)
            {
                gridPnl.BackgroundImage = Properties.Resources.ironGrid;
                WhiteColor();
            }
            else if (backgroundImagePnl.BackColor == Color.Green)
            {
                gridPnl.BackgroundImage = Properties.Resources.pokerGrid;
                WhiteColor();
            }
            else if (backgroundImagePnl.BackColor == Color.Transparent)
            {
                gridPnl.BackgroundImage = Properties.Resources.neonGrid;
                foregroundImagePnl.BackColor = Color.Black;
                foregroundImagePnl.BackgroundImage = Properties.Resources.transparent;
                WhiteColor();
            }
            else
            {
                foregroundImagePnl.BackColor = Color.Gray;
                gridPnl.BackgroundImage = Properties.Resources.grayGrid;
                gridPnl.BackgroundImage = Properties.Resources.grayGrid;
                WhiteColor();
            }

            // Adjust the size of panels based on the code length
            AdjustLayoutBasedOnCodeLength(initCodeLength);

            // Adjust the size of the grids based on the code length
            colorBtnGrid = new Label[ROWS, initCodeLength];
            hintBtnGrid = new Label[ROWS, initCodeLength];

            // Initialize the grids
            ColorGridInitialize();
            HintGridInitialize();
            ColorBtnInitialize();
        }

        /// <summary>
        /// Change the color of the buttons to white
        /// </summary>
        private void WhiteColor()
        {
            menuBtn.ForeColor = Color.White;
            undoBtn.ForeColor = Color.White;
            resetBtn.ForeColor = Color.White;
            validBtn.ForeColor = Color.White;
        }

        /// <summary>
        /// Initialize the color buttons
        /// </summary>
        private void ColorBtnInitialize()
        {
            colorBtnInit = new Button[initColorLength];

            for (int i = 0; i < initColorLength; i++)
            {
                Button colorButton = new Button
                {
                    Size = new System.Drawing.Size(40, 40),
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                };

                colorButton.FlatAppearance.BorderSize = 0;
                colorButton.BackgroundImageLayout = ImageLayout.Stretch;
                colorButton.Anchor = AnchorStyles.None;
                colorButton.Click += Bouton_Click;
                colorButton.MouseDown += Bouton_MouseDown;
                colorButton.MouseUp += Bouton_MouseUp;

                if (CBisChecked)
                {
                    colorButton.BackColor = CBcodeColors[i];

                    if (backgroundImagePnl.BackColor == Color.Gray)
                    {
                        colorButton.BackgroundImage = Properties.Resources.transparent;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Brown)
                    {
                        colorButton.BackgroundImage = CBcolorsImage[i];
                    }
                    else if (backgroundImagePnl.BackColor == Color.Red)
                    {
                        colorButton.BackgroundImage = CBironColorsImage[i];
                    }
                    else if (backgroundImagePnl.BackColor == Color.Green)
                    {
                        colorButton.BackgroundImage = CBpokerColorsImage[i];
                    }
                    else if (backgroundImagePnl.BackColor == Color.Transparent)
                    {
                        colorButton.BackgroundImage = CBneonColorsImage[i];
                    }
                }
                else
                {
                    colorButton.BackColor = codeColors[i];

                    if (backgroundImagePnl.BackColor == Color.Gray)
                    {
                        colorButton.BackgroundImage = Properties.Resources.transparent;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Brown)
                    {
                        colorButton.BackgroundImage = colorsImage[i];
                    }
                    else if (backgroundImagePnl.BackColor == Color.Red)
                    {
                        colorButton.BackgroundImage = ironColorsImage[i];
                    }
                    else if (backgroundImagePnl.BackColor == Color.Green)
                    {
                        colorButton.BackgroundImage = pokerColorsImage[i];
                    }
                    else if (backgroundImagePnl.BackColor == Color.Transparent)
                    {
                        colorButton.BackgroundImage = neonColorsImage[i];
                    }
                    else
                    {
                        colorButton.BackgroundImage = Properties.Resources.transparent;
                    }
                }

                // Makes the buttons round
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath(); 
                path.AddEllipse(0, 0, colorButton.Width - 1, colorButton.Height - 1);
                colorButton.Region = new Region(path);

                colorBtnPnl.Controls.Add(colorButton);
                colorBtnInit[i] = colorButton;
            }
        }

        /// <summary>
        /// Create buttons for colors
        /// </summary>
        private void ColorGridInitialize()
        {
            colorBtnGrid = new Label[ROWS, initCodeLength];

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < initCodeLength; j++)
                {
                    Label guessButton = new Label
                    {
                        Size = new Size(35, 35),
                        FlatStyle = FlatStyle.Flat,
                        Location = new Point(j * 50, i * 60),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Enabled = false,
                        Anchor = AnchorStyles.None
                    };

                    // Set background image based on background color
                    if (backgroundImagePnl.BackColor == Color.Brown)
                    {
                        guessButton.BackgroundImage = Properties.Resources.trou;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Red)
                    {
                        guessButton.BackgroundImage = Properties.Resources.iron_trou;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Green)
                    {
                        guessButton.BackgroundImage = Properties.Resources.poker_trou;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Transparent)
                    {
                        guessButton.BackgroundImage = Properties.Resources.neon_trou;
                    }
                    else
                    {
                        guessButton.BackgroundImage = Properties.Resources.classic_trou;
                    }

                    // Makes the labels round
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, guessButton.Width - 1, guessButton.Height - 1);
                    guessButton.Region = new Region(path);

                    colorPnl.Controls.Add(guessButton);
                    colorBtnGrid[i, j] = guessButton;
                }
            }
        }

        /// <summary>
        /// Create buttons for hints
        /// </summary>
        private void HintGridInitialize()
        {
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < initCodeLength; j++)
                {
                    Label hintButton = new Label
                    {
                        Size = new System.Drawing.Size(20, 20),
                        FlatStyle = FlatStyle.Flat,
                        Location = new Point(j * 30, i * 60),
                        Enabled = false,
                        Anchor = AnchorStyles.None
                    };

                    // Set background image based on background color
                    if (backgroundImagePnl.BackColor == Color.Brown)
                    {
                        hintButton.BackgroundImage = Properties.Resources.petitTrou;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Red)
                    {
                        hintButton.BackgroundImage = Properties.Resources.iron_petitTrou;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Green)
                    {
                        hintButton.BackgroundImage = Properties.Resources.poker_petitTrou;
                    }
                    else if (backgroundImagePnl.BackColor == Color.Transparent)
                    {
                        hintButton.BackgroundImage = Properties.Resources.neon_petitTrou;
                    }
                    else
                    {
                        hintButton.BackgroundImage = Properties.Resources.classic_petitTrou;
                    }

                    // Makes the labels round
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddEllipse(0, 0, hintButton.Width - 1, hintButton.Height - 1);
                    hintButton.Region = new Region(path);

                    hintPnl.Controls.Add(hintButton);
                    hintBtnGrid[i, j] = hintButton;
                }
            }
        }

        /// <summary>
        /// Generates the code
        /// </summary>
        private void GenerateCode()
        {
            Random random = new Random();
            Color randomCodeButton = new Color();

            for (int i = 0; i < initCodeLength; i++)
            {
                // Determine the color based on color blindness setting
                if (CBisChecked)
                {
                    randomCodeButton = CBcodeColors[random.Next(initCodeLength)];
                }
                else
                {
                    randomCodeButton = codeColors[random.Next(initColorLength)];
                }

                Label secretCode = new Label
                {
                    Size = new Size(35, 35),
                    BackColor = randomCodeButton,
                    Location = new Point(i * 50),
                    Enabled = false,
                    FlatStyle = FlatStyle.Flat,
                    Anchor = AnchorStyles.None
                };

                // Makes the labels round
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, secretCode.Width - 1, secretCode.Height - 1);
                secretCode.Region = new Region(path);

                codePnl.Controls.Add(secretCode);
                colorsSecretCode[i] = secretCode;
            }
        }
        #endregion

        #region Form Animation
        /// <summary>
        /// Changes the size of the color button when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bouton_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            // Adjust the size of the button downward
            button.Size = new Size(button.Width - 5, button.Height - 5);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, button.Width - 1, button.Height - 1);
            button.Region = new Region(path);
        }

        private void Bouton_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            // Adjust the size of the button upward
            button.Size = new Size(button.Width + 5, button.Height + 5);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, button.Width - 1, button.Height - 1);
            button.Region = new Region(path);
        }
        #endregion

        #region Form Verification

        /// <summary>
        /// Clicking the color button updates other buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bouton_Click(object sender, EventArgs e)
        {
            // Show an error message when the code limit is exceeded
            if (currentColumn < initCodeLength)
            {
                Button colorButton = (Button)sender;

                // Display the clicked button on the grid
                colorBtnGrid[currentLine, currentColumn].BackColor = colorButton.BackColor;
                colorBtnGrid[currentLine, currentColumn].BackgroundImage = colorButton.BackgroundImage;

                currentColumn++;

                // Enable the validate button when the code is complete
                validBtn.Enabled = (currentColumn == initCodeLength);
            }

            else
            {
                ShowCodeLimitWarning();
            }
        }

        /// <summary>
        /// Displays a warning message about reaching the maximum code length.
        /// </summary>
        private void ShowCodeLimitWarning()
        {
            string languageWarning = GetLanguageWarning();
            MessageBox.Show($"{initCodeLength} {languageWarning}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Gets the language-specific warning message.
        /// </summary>
        /// <returns></returns>
        private string GetLanguageWarning()
        {
            bool IsEnglishChecked = optionsBG.IsEnglishChecked;
            bool IsGermanChecked = optionsBG.IsGermanChecked;
            bool IsItalianChecked = optionsBG.IsItalianChecked;

            if (IsEnglishChecked)
            {
                return "colors max";
            }
            else if (IsItalianChecked)
            {
                return "colore massimi";
            }
            else if (IsGermanChecked)
            {
                return "Farben maximal";
            }
            else
            {
                return "couleurs max";
            }
        }

        /// <summary>
        /// Handles the click event of the Undo button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if (currentColumn > 0)
            {
                // Reset the code size when undoing
                currentColumn--;

                // Clear the last button
                colorBtnGrid[currentLine, currentColumn].BackColor = Color.Transparent;
                colorBtnGrid[currentLine, currentColumn].BackgroundImage = GetEmptyButtonImage();

                validBtn.Enabled = false;
            }
        }

        /// <summary>
        /// Gets the image for an empty button based on the background color.
        /// </summary>
        /// <returns></returns>
        private Image GetEmptyButtonImage()
        {
            Color backColor = backgroundImagePnl.BackColor;

            return backColor == Color.Brown ? Properties.Resources.trou :
                   backColor == Color.Red ? Properties.Resources.iron_trou :
                   backColor == Color.Green ? Properties.Resources.poker_trou :
                   backColor == Color.Transparent ? Properties.Resources.neon_trou :
                   Properties.Resources.classic_trou;
        }

        /// <summary>
        /// Validates the code entered by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidBtn_Click(object sender, EventArgs e)
        {
            CheckCode();

            // Reset the color counter to zero
            currentColumn = 0;
            validBtn.Enabled = false;
        }

        /// <summary>
        /// Checks the entered code against the secret code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCode()
        {
            bool IsEnglishChecked = optionsBG.IsEnglishChecked;
            bool IsGermanChecked = optionsBG.IsGermanChecked;
            bool IsItalianChecked = optionsBG.IsItalianChecked;

            // Check the colors in the code
            int rightPlace = 0;
            int rightColor = 0;

            // Arrays storing the occurrences of each color in the secret code and user input
            int[] secretColorCount = new int[codeColors.Length];
            int[] inputColorCount = new int[codeColors.Length];

            // Count the occurrences of each color in the secret code
            for (int i = 0; i < initCodeLength; i++)
            {
                if (CBisChecked)
                {
                    secretColorCount[Array.IndexOf(CBcodeColors, colorsSecretCode[i].BackColor)]++;
                }
                else
                {
                    secretColorCount[Array.IndexOf(codeColors, colorsSecretCode[i].BackColor)]++;
                }
            }

            // Count the occurrences of each color in the user input
            for (int i = 0; i < initCodeLength; i++)
            {
                if (CBisChecked)
                {
                    inputColorCount[Array.IndexOf(CBcodeColors, colorBtnGrid[currentLine, i].BackColor)]++;
                }
                else
                {
                    inputColorCount[Array.IndexOf(codeColors, colorBtnGrid[currentLine, i].BackColor)]++;
                }
            }

            // Check if the color is correct in the corresponding position in the secret code
            for (int i = 0; i < initCodeLength; i++)
            {
                if (colorBtnGrid[currentLine, i].BackColor == colorsSecretCode[i].BackColor)
                {
                    // Correct color in the right place
                    rightPlace++;
                }
            }

            // Increment the attempt counter
            clickCounter++;

            // If the code matches
            if (rightPlace == initCodeLength)
            {
                // Shows the secret code when the game is won
                codePnl.Show();

                if (cheater)
                {
                    // Plays the cheater jingle
                    cheat.Play();

                    // Display a congratulatory message in the appropriate language
                    if (IsEnglishChecked)
                    {
                        MessageBox.Show($"Congratulation, you cheated", "It is not because you can that you should", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (IsGermanChecked)
                    {
                        MessageBox.Show($"Herzlichen Glückwunsch, Sie haben geschummelt", "Nicht weil Sie es kann, sollten Sie es tun", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (IsItalianChecked)
                    {
                        MessageBox.Show($"Bravissimo, hai tradito", "Non è perché puoi che dovresti", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MessageBox.Show($"Félicitation, tu as triché", "Ce n'est pas parce que tu peux que tu devrais", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    // Plays the winning jingle
                    win.Play();

                    // Display a congratulatory message in the appropriate language
                    if (IsEnglishChecked)
                    {
                        MessageBox.Show(currentLine == 0 ? $"Well done, you won in {currentLine + 1} try" : $"Well done, you won in {currentLine + 1} tries", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (IsGermanChecked)
                    {
                        MessageBox.Show(currentLine == 0 ? $"Gut gemacht, Sie haben in {currentLine + 1} Versuch gewonnen" : $"Gut gemacht, Sie haben in {currentLine + 1} Versuchen gewonnen", "Herzlichen Glückwunsch", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (IsItalianChecked)
                    {
                        MessageBox.Show(currentLine == 0 ? $"Bravissimo, hai vinto in {currentLine + 1} tentativo" : $"Bravissimo, hai vinto in {currentLine + 1} tentativi", "Congratulazioni", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show(currentLine == 0 ? $"Bravo, vous avez gagné en {currentLine + 1} essai" : $"Bravo, vous avez gagné en {currentLine + 1} essais", "Félicitations", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                // Reset the game state
                ResetAll();
                return;
            }
            // If the maximum attempts are reached
            else if (clickCounter == 10)
            {
                // Shows the secret code when the game is lost
                codePnl.Show();

                // Plays the losing jingle
                lose.Play();

                // Display a message for losing the game in the appropriate language
                if (IsEnglishChecked)
                {
                    MessageBox.Show($"Sorry, you lost. You'll do better next time", "Too bad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (IsGermanChecked)
                {
                    MessageBox.Show($"Tut mir leid, du hast verloren. Das nächste Mal machst du es besser", "Schade", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (IsItalianChecked)
                {
                    MessageBox.Show($"Mi dispiace, hai perso. Farai meglio la prossima volta", "Peccato", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show($"Désolé, vous avez perdu. Vous ferez mieux la prochaine fois", "Dommage", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                // Reset the game state
                ResetAll();
                return;
            }
            else
            {
                // Correct colors but in the wrong place
                for (int i = 0; i < codeColors.Length; i++)
                {
                    rightColor += Math.Min(secretColorCount[i], inputColorCount[i]);
                }

                rightColor -= rightPlace;

                // Set the hints in the array based on the results
                for (int i = 0; i < initCodeLength; i++)
                {
                    if (i < rightPlace)
                    {
                        // Change the type of hint button
                        if (backgroundImagePnl.BackColor == Color.Brown)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.littleWhite;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Red)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.white_little_iron;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Green)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.white_little_poker;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Transparent)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.white_little_neon;
                        }
                        else
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.transparent;
                            hintBtnGrid[currentLine, i].BackColor = Color.White;
                        }
                    }
                    else if (i >= rightPlace && i < rightPlace + rightColor)
                    {
                        if (backgroundImagePnl.BackColor == Color.Brown)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.littleBlack;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Red)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.black_little_iron;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Green)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.black_little_poker;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Transparent)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.black_little_neon;
                        }
                        else
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.transparent;
                            hintBtnGrid[currentLine, i].BackColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (backgroundImagePnl.BackColor == Color.Brown)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.petitTrou;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Red)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.iron_petitTrou;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Green)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.poker_petitTrou;
                        }
                        else if (backgroundImagePnl.BackColor == Color.Transparent)
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.neon_petitTrou;
                        }
                        else
                        {
                            hintBtnGrid[currentLine, i].BackgroundImage = Properties.Resources.classic_petitTrou;
                        }
                    }
                }
            }
            // Increment the line counter after the methods to avoid restarting from line 2
            currentLine++;
        }
        #endregion

        #region Form Buttons
        /// <summary>
        /// Returns to the main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Show the main menu
            mainMenu.Show();
        }

        /// <summary>
        /// Resets all game-related variables and controls to start a new game.
        /// </summary>
        private void ResetAll()
        {
            currentColumn = 0;
            currentLine = 0;
            clickCounter = 0;
            validBtn.Enabled = false;

            // Clear color panel controls and reinitialize color grid
            colorPnl.Controls.Clear();
            ColorGridInitialize();

            // Clear hint panel controls and reinitialize hint grid
            hintPnl.Controls.Clear();
            HintGridInitialize();

            // Clear code panel controls and generate a new secret code
            codePnl.Controls.Clear();
            GenerateCode();

            // Clears the cheater form his sin
            cheater = false;

            // Hide the code panel
            codePnl.Hide();
        }

        /// <summary>
        /// Handles the click event of the Reset button to reset the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        /// <summary>
        /// Shows/hides the cheat button when certain keys are pressed.
        /// </summary>
        private void CodePnl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.C:
                    codePnl.Visible = true;
                    // Changes the state of the cheater
                    cheater = true;
                    break;
                case Keys.D:
                    codePnl.Visible = false;
                    break;
            }
        }
        #endregion
    }
}
