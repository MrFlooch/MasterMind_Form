using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasterMind_Form
{
    public partial class Options : Form
    {
        #region Form Variables
        // Link to the other forms
        readonly Menu mainMenu;
        // Array to store color buttons
        Label[] colorBtnGrid;
        // Background image for the form
        Image backgroundImg;
        // Background color for the form
        Color backgroundColor;

        // Language Options
        public bool IsEnglishChecked;
        public bool IsGermanChecked;
        public bool IsItalianChecked;

        // Color Blindness Options
        public bool CBisChecked;

        // Constant representing the length of color arrays
        const int COLOR_LENGTH = 7;

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

        #region Form Initialization
        public Options(Menu menu)
        {
            InitializeComponent();
            // Set the initial position of the window to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Reference to the main menu form
            this.mainMenu = menu;
        }
        /// <summary>
        /// Handles the Load event of the Option form.
        /// </summary>
        private void Options_Load(object sender, EventArgs e)
        {
            colorBtnGrid = new Label[COLOR_LENGTH];
            ColorBtnInitialize();
            backgroundImg = Properties.Resources.transparent;
            forgroundPnl.BackColor = Color.Gray;
        }

        /// <summary>
        /// Initialize the color buttons
        /// </summary>
        private void ColorBtnInitialize()
        {
            for (int i = 0; i < COLOR_LENGTH; i++)
            {
                Label colorPnl = new Label
                {
                    BackColor = codeColors[i],
                    Size = new System.Drawing.Size(50, 50),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Anchor = AnchorStyles.None
                };

                // Makes the labels round
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath(); //rend le bouton round
                path.AddEllipse(0, 0, colorPnl.Width, colorPnl.Height);
                colorPnl.Region = new Region(path);

                colorLayoutPnl.Controls.Add(colorPnl);
                colorBtnGrid[i] = colorPnl;
            }
        }
        #endregion

        #region Form Background Image Methods
        /// <summary>
        /// Gets the currently selected background image.
        /// </summary>
        /// <returns>The background image.</returns>
        public Image GetImageBackground()
        {
            return backgroundImg;
        }

        /// <summary>
        /// Gets the currently selected background color.
        /// </summary>
        /// <returns>The background color.</returns>
        public Color GetColor()
        {
            return backgroundColor;
        }

        /// <summary>
        /// Sets text color to white for various UI elements.
        /// </summary>
        private void WhiteForColor()
        {
            menuBtn.ForeColor = Color.White;
            optionTitle.ForeColor = Color.White;
            optionCheckBox.ForeColor = Color.White;
            optionText.ForeColor = Color.White;
            FrenchBx.ForeColor = Color.White;
            EnglishBx.ForeColor = Color.White;
            GermanBx.ForeColor = Color.White;
            ItalianBx.ForeColor = Color.White;
        }

        /// <summary>
        /// Sets text color to black for various UI elements.
        /// </summary>
        private void BlackForColor()
        {
            menuBtn.ForeColor = Color.Black;
            optionTitle.ForeColor = Color.Black;
            optionCheckBox.ForeColor = Color.Black;
            optionText.ForeColor = Color.Black;
            FrenchBx.ForeColor = Color.Black;
            EnglishBx.ForeColor = Color.Black;
            GermanBx.ForeColor = Color.Black;
            ItalianBx.ForeColor = Color.Black;
        }

        /// <summary>
        /// Handles the event when clicking on the classic button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BackgroundBtn_Click(object sender, EventArgs e)
        {
            // Set foreground panel properties
            forgroundPnl.BackColor = Color.Gray;
            forgroundPnl.BackgroundImage = Properties.Resources.transparent;

            // Set background panel properties
            backgroundPnl.BackColor = Color.Gray;

            // Call method to set color of labels to white
            WhiteForColor();

            // Set background image and color variables
            backgroundImg = Properties.Resources.transparent;
            backgroundColor = Color.Gray;

            // Set color buttons based on the selected option
            for (int i = 0; i < COLOR_LENGTH; i++)
            {
                // Set color button background color for color blindness mode
                if (optionCheckBox.Checked)
                {
                    colorBtnGrid[i].BackColor = CBcodeColors[i];
                    colorBtnGrid[i].BackgroundImage = Properties.Resources.transparent;
                }
                // Set color button background color for normal mode
                else
                {
                    colorBtnGrid[i].BackColor = codeColors[i];
                    colorBtnGrid[i].BackgroundImage = Properties.Resources.transparent;
                }
            }
        } // Fin BackgroundBtn_Click

        /// <summary>
        /// Event handler for the Wood background button.
        /// </summary>
        public void WoodBackgroundBtn_Click(object sender, EventArgs e)
        {
            // Set background properties for Wood theme
            forgroundPnl.BackgroundImage = Properties.Resources.wood;
            forgroundPnl.BackColor = Color.Transparent;
            backgroundPnl.BackColor = Color.Brown;
            forgroundPnl.BackgroundImageLayout = ImageLayout.Stretch;

            // Set text color to black for UI elements
            BlackForColor();

            // Set background image and color variables
            backgroundImg = Properties.Resources.wood;
            backgroundColor = Color.Brown;

            // Set color buttons based on the selected option
            for (int i = 0; i < COLOR_LENGTH; i++)
            {
                if (optionCheckBox.Checked)
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = CBcolorsImage[i];
                }
                else
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = colorsImage[i];
                }
            }
        } // Fin WoodBackgroundBtn_Click 

        /// <summary>
        /// Event handler for the Iron background button.
        /// </summary>
        public void IronBackgroundBtn_Click(object sender, EventArgs e)
        {
            // Set background properties for Iron theme
            forgroundPnl.BackgroundImage = Properties.Resources.iron;
            forgroundPnl.BackColor = Color.Transparent;
            forgroundPnl.BackgroundImageLayout = ImageLayout.Stretch;
            backgroundPnl.BackColor = Color.Red;

            // Set text color to white for UI elements
            WhiteForColor();

            // Set background image and color variables
            backgroundImg = Properties.Resources.iron;
            backgroundColor = Color.Red;

            // Set color buttons based on the selected option
            for (int i = 0; i < COLOR_LENGTH; i++)
            {
                if (optionCheckBox.Checked)
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = CBironColorsImage[i];
                }
                else
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = ironColorsImage[i];
                }
            }
        } // Fin IronBackgroundBtn_Click

        /// <summary>
        /// Event handler for the Wool background button.
        /// </summary>
        public void WoolBackgroundBtn_Click(object sender, EventArgs e)
        {
            // Set background properties for Wool theme
            forgroundPnl.BackgroundImage = Properties.Resources.wool;
            forgroundPnl.BackColor = Color.Transparent;
            forgroundPnl.BackgroundImageLayout = ImageLayout.Stretch;
            backgroundPnl.BackColor = Color.Green;

            // Set text color to white for UI elements
            WhiteForColor();

            // Set background image and color variables
            backgroundImg = Properties.Resources.wool;
            backgroundColor = Color.Green;

            // Set color buttons based on the selected option
            for (int i = 0; i < COLOR_LENGTH; i++)
            {
                if (optionCheckBox.Checked)
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = CBpokerColorsImage[i];
                }
                else
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = pokerColorsImage[i];
                }
            }
        } // Fin WoolBackgroundBtn_Click

        /// <summary>
        /// Event handler for the Neon background button.
        /// </summary>
        public void NeonBackgroundBtn_Click(object sender, EventArgs e)
        {
            // Set background properties for Neon theme
            forgroundPnl.BackColor = Color.Transparent;
            forgroundPnl.BackgroundImage = Properties.Resources.transparent;
            backgroundPnl.BackColor = Color.Black;

            // Set text color to white for UI elements
            WhiteForColor();

            // Set background image and color variables
            backgroundImg = Properties.Resources.blackBG;
            backgroundColor = Color.Transparent;

            // Set color buttons based on the selected option
            for (int i = 0; i < COLOR_LENGTH; i++)
            {
                if (optionCheckBox.Checked)
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = CBneonColorsImage[i];
                }
                else
                {
                    colorBtnGrid[i].BackColor = Color.Transparent;
                    colorBtnGrid[i].BackgroundImage = neonColorsImage[i];
                }
            }
        } // Fin NeonBackgroundBtn_Click

        /// <summary>
        /// Event handler for the Menu button.
        /// </summary>
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the main menu
            this.Hide();
            mainMenu.Show();
        }

        #endregion

        #region Form Language Selection
        /// <summary>
        /// Event handler for language selection checkboxes.
        /// </summary>
        private void LanguagesBx_CheckedChanged(object sender, EventArgs e)
        {
            // English language selected
            if (EnglishBx.Checked)
            {
                // Set UI elements for English language
                this.Text = "MasterMind - Options";
                optionTitle.Text = "Options";
                optionCheckBox.Text = "Color blindness";
                optionText.Text = "Language";
                menuBtn.Text = "Menu";
                normalBackgroundBtn.Text = "Classic";
                woodBackgroundBtn.Text = "Wood";
                ironBackgroundBtn.Text = "Iron";

                // Update language flags
                IsEnglishChecked = true;
                IsItalianChecked = false;
                IsGermanChecked = false;
            }
            // Italian language selected
            else if (ItalianBx.Checked)
            {
                // Set UI elements for Italian language
                this.Text = "MasterMind - Opzioni";
                optionTitle.Text = "Opzioni";
                optionCheckBox.Text = "Daltonismo";
                optionText.Text = "Lingua";
                menuBtn.Text = "Menu";
                normalBackgroundBtn.Text = "Classico";
                woodBackgroundBtn.Text = "Legno";
                ironBackgroundBtn.Text = "Ferro";

                // Update language flags
                IsEnglishChecked = false;
                IsItalianChecked = true;
                IsGermanChecked = false;
            }
            // German language selected
            else if (GermanBx.Checked)
            {
                // Set UI elements for German language
                this.Text = "MasterMind - Optionen";
                optionTitle.Text = "Optionen";
                optionCheckBox.Text = "Farbenblindheit";
                optionText.Text = "Sprache";
                menuBtn.Text = "Menü";
                normalBackgroundBtn.Text = "Klassisch";
                woodBackgroundBtn.Text = "Holz";
                ironBackgroundBtn.Text = "Eisen";

                // Update language flags
                IsEnglishChecked = false;
                IsItalianChecked = false;
                IsGermanChecked = true;
            }

            // French language selected
            else
            {
                // Set UI elements for French language
                this.Text = "MasterMind - Options";
                optionTitle.Text = "Options";
                optionCheckBox.Text = "Daltonisme";
                optionText.Text = "Langue";
                menuBtn.Text = "Menu";
                normalBackgroundBtn.Text = "Classique";
                woodBackgroundBtn.Text = "Bois";
                ironBackgroundBtn.Text = "Fer";

                // Update language flags
                IsEnglishChecked = false;
                IsItalianChecked = false;
                IsGermanChecked = false;
            }
        } // Fin LanguagesBx_CheckedChanged
        #endregion

        #region Form Color Blindness Option
        /// <summary>
        /// Handles the color blindness checkbox state change.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void optionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < COLOR_LENGTH; i++)
            {
                // Set color for color blindness 
                if (optionCheckBox.Checked)
                {
                    CBisChecked = true;

                    if (backgroundPnl.BackColor == Color.Gray)
                    {
                        colorBtnGrid[i].BackColor = CBcodeColors[i];
                        colorBtnGrid[i].BackgroundImage = Properties.Resources.transparent;
                    }
                    else if (backgroundPnl.BackColor == Color.Brown)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = CBcolorsImage[i];
                    }
                    else if (backgroundPnl.BackColor == Color.Red)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = CBironColorsImage[i];
                    }
                    else if (backgroundPnl.BackColor == Color.Green)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = CBpokerColorsImage[i];
                    }
                    else if (backgroundPnl.BackColor == Color.Black)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = CBneonColorsImage[i];
                    }
                }
                // Set regular colors
                else
                {
                    CBisChecked = false;

                    if (backgroundPnl.BackColor == Color.Gray)
                    {
                        colorBtnGrid[i].BackColor = codeColors[i];
                        colorBtnGrid[i].BackgroundImage = Properties.Resources.transparent;
                    }
                    else if (backgroundPnl.BackColor == Color.Brown)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = colorsImage[i];
                    }
                    else if (backgroundPnl.BackColor == Color.Red)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = ironColorsImage[i];
                    }
                    else if (backgroundPnl.BackColor == Color.Green)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = pokerColorsImage[i];
                    }
                    else if (backgroundPnl.BackColor == Color.Black)
                    {
                        colorBtnGrid[i].BackColor = Color.Transparent;
                        colorBtnGrid[i].BackgroundImage = neonColorsImage[i];
                    }
                }
            }
        } // Fin optionCheckBox_CheckedChanged
        #endregion

        #region Form Closing
        /// <summary>
        /// Handles the form closing event.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Form closing event arguments.</param>
        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
