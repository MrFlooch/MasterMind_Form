using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasterMind_Form
{
    public partial class Rules : Form
    {
        #region Form Fields
        // Link to the other forms
        private readonly Menu mainMenu;
        private readonly Options optionsBG;
        #endregion

        #region Form Constructor
        public Rules(Menu menu, Options options)
        {
            InitializeComponent();

            // Set the initial position of the window to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Store references to other forms
            mainMenu = menu;
            optionsBG = options;
            // Sets the background images and colors based on options
            foregroundImagePnl.BackgroundImage = optionsBG.GetImageBackground();
            backgroundImagePnl.BackColor = optionsBG.GetColor();
        }
        private void Rules_Load(object sender, EventArgs e)
        {
            SetTextAndColors();

            // Configures appearance based on the selected background color
            if (backgroundImagePnl.BackColor == Color.Gray)
            {
                textPnl.BackColor = Color.DimGray;
                textPnl.BorderStyle = BorderStyle.Fixed3D;
                ChangeColorWhite();
            }
            else if (backgroundImagePnl.BackColor == Color.Brown)
            {
                textPnl.BackgroundImage = Properties.Resources.lightwood;
                SetImageLayoutAndColors(Color.Transparent, BorderStyle.None, Color.Black);
            }
            else if (backgroundImagePnl.BackColor == Color.Red)
            {
                textPnl.BackgroundImage = Properties.Resources.lightiron;
                SetImageLayoutAndColors(Color.Transparent, BorderStyle.None, Color.White);
            }
            else if (backgroundImagePnl.BackColor == Color.Green)
            {
                textPnl.BackgroundImage = Properties.Resources.lightpoker;
                SetImageLayoutAndColors(Color.Transparent, BorderStyle.None, Color.White);
            }
            else if (backgroundImagePnl.BackColor == Color.Transparent)
            {
                foregroundImagePnl.BackgroundImage = Properties.Resources.transparent;
                foregroundImagePnl.BackColor = Color.Black;
                textPnl.BackgroundImage = Properties.Resources.lightneon;
                SetImageLayoutAndColors(Color.Transparent, BorderStyle.None, Color.White);
            }
        }
        /// <summary>
        /// Configures the appearance of the text panel and labels
        /// </summary>
        /// <param name="backgroundColor"></param>
        /// <param name="borderStyle"></param>
        /// <param name="labelColor"></param>
        private void SetImageLayoutAndColors(Color backgroundColor, BorderStyle borderStyle, Color labelColor)
        {
            textPnl.BackgroundImageLayout = ImageLayout.Stretch;
            textPnl.BackColor = backgroundColor;
            textPnl.BorderStyle = borderStyle;
            textLbl.ForeColor = labelColor;
            ruleTitle.ForeColor = labelColor;
            menuBtn.ForeColor = labelColor;
        }

        /// <summary>
        /// Checks if the RadioButton is checked in the "Options" form
        /// </summary>        
        private void SetTextAndColors()
        {
            bool IsEnglishChecked = optionsBG.IsEnglishChecked;
            bool IsGermanChecked = optionsBG.IsGermanChecked;
            bool IsItalianChecked = optionsBG.IsItalianChecked;

            // Sets text and labels based on the selected language
            if (IsEnglishChecked)
            {
                this.Text = "MasterMind - Rules";
                textLbl.Text = "You need to find the secret color combination with the following colors:\r\nGreen, yellow, white, red, blue, magenta and cyan.\r\n\r\nYou can choose the number of colors and the size of the code.\r\nSome codes may have the same color several times.\r\nYou have several attempts, but be careful, you only have 10.\r\n\r\nIf you place one or more colors correctly, the console will indicate it to you with a white dot\r\nnext to your code.\r\n\r\nIf you place one or more correct colors but not in the right place, the console will tell you\r\nwith a black dot next to your code.\r\n";
                ruleTitle.Text = "Rules";
                menuBtn.Text = "Menu";
            }
            else if (IsGermanChecked)
            {
                this.Text = "MasterMind - Regeln";
                textLbl.Text = "Sie müssen die geheime Farbkombination mit den folgenden Farben finden:\r\nGrün, Gelb, Weiß, Rot, Blau, Magenta und Cyan.\r\n\r\nSie können die Anzahl der Farben und die Größe des Codes wählen.\r\nEinige Codes können mehrmals die selbe Farbe haben.\r\nSie haben mehrere Versuche, aber seien Sie vorsichtig, Sie haben nur 10.\r\n\r\nWenn Sie eine oder mehrere Farben richtig platzieren, zeigt Ihnen die Konsole dies mit einem weißen Punkt \r\nan neben Ihrem Code.\r\n\r\nWenn Sie eine oder mehrere richtige Farben, aber nicht an der richtigen Stelle platzieren, wird Ihnen\r\ndie Konsole dies mitteilen mit einem schwarzen Punkt neben Ihrem Code.\r\n";
                ruleTitle.Text = "Regeln";
                menuBtn.Text = "Menü";
            }
            else if (IsItalianChecked)
            {
                this.Text = "MasterMind - Regole";
                textLbl.Text = "Devi trovare la combinazione di colori segreta con i seguenti colori:\r\nVerde, giallo, bianco, rosso, blu, magenta e ciano.\r\n\r\nPuoi scegliere il numero di colori e la dimensione del codice.\r\nAlcuni codici possono avere più volte lo stesso colore.\r\nHai diversi tentativi, ma fai attenzione, ne hai solo 10.\r\n\r\nSe posizioni correttamente uno o più colori, la console te lo indicherà con un punto bianco\r\naccanto al tuo codice.\r\n\r\nSe inserisci uno o più colori corretti ma non al posto giusto, la console te lo avviserà\r\ncon un punto nero accanto al codice.\r\n";
                ruleTitle.Text = "Regole";
                menuBtn.Text = "Menu";
            }
            else
            {
                this.Text = "MasterMind - Règles";
                textLbl.Text = "Vous devez trouver la combinaison de couleurs secrètes avec les couleurs suivantes : \r\nVert, jaune, blanc, rouge, bleu, magenta et cyan.\r\n\r\nVous pouvez choisir le nombre de couleurs et la taille du code. \r\nCertains codes peuvent comporter plusieurs fois la même couleur.  \r\nVous avez plusieurs essais, mais attention, vous n'en avez que 10.\r\n\r\nSi vous placez une ou plusieurs couleurs correctement, la console vous l'indiquera avec un point blanc \r\nà coté de votre code. \r\n\r\nSi vous placez une ou plusieurs bonnes couleurs mais pas au bon endroit, la console vous l'indiquera \r\navec un point noir à coté de votre code.\r\n";
                ruleTitle.Text = "Règles";
                menuBtn.Text = "Menu";
            }
        } // Fin SetTextAndColors
        #endregion

        #region Form Private Methods
        /// <summary>
        ///  Changes the color of the text to white
        /// </summary>
        private void ChangeColorWhite()
        {
            textPnl.BackColor = Color.Transparent;
            textLbl.ForeColor = Color.White;
            ruleTitle.ForeColor = Color.White;
            menuBtn.ForeColor = Color.White;
        }
        #endregion

        #region Form Button Click Events
        /// <summary>
        /// Closes the current window and shows the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            // Ferme le fenêtre actuelle
            this.Hide();
            mainMenu.Show();
        }
        /// <summary>
        /// Exits the application when the form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
