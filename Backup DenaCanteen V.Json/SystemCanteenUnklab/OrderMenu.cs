using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemCanteenUnklab;

namespace SystemCanteenUnklab
{
    public partial class OrderMenu : Form
    {
        private Dictionary<string, ButtonStateColors> buttonStates = new Dictionary<string, ButtonStateColors>();
        private Dictionary<string, ButtonState> lastButtonStates = new Dictionary<string, ButtonState>();
        private Button[] allButtons;

        public OrderMenu()
        {
            InitializeComponent();

            allButtons = new Button[]
            {
            BtnA1, BtnA2, BtnA3, BtnB1, BtnB2, BtnB3,
            BtnC1, BtnC2, BtnC3, BtnEXA1, BtnEXA2, BtnEXA3,
            BtnEXB1, BtnEXB2, BtnEXB3
            };

            foreach (var button in allButtons)
            {
                button.Click += Button_Click;
            }

            // Load saved buttonStates from application settings
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ButtonState))
            {
                string buttonStateJson = Properties.Settings.Default.ButtonState;
                buttonStates = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, ButtonStateColors>>(buttonStateJson);
                // Restore the button colors based on the loaded buttonStates
                RestoreButtonColors();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonName = clickedButton.Name;

            if (!buttonStates.ContainsKey(buttonName))
            {
                buttonStates[buttonName] = new ButtonStateColors();
            }

            ButtonStateColors stateColors = buttonStates[buttonName];

            switch (stateColors.CurrentState)
            {
                case ButtonState.Initial:
                    stateColors.InitialStateForeColor = clickedButton.ForeColor = Color.Black;
                    stateColors.InitialStateBackColor = clickedButton.BackColor = Color.Gray;
                    stateColors.CurrentState = ButtonState.FirstClicked;
                    break;

                case ButtonState.FirstClicked:
                    stateColors.FirstClickedStateForeColor = clickedButton.ForeColor = Color.Black;
                    stateColors.FirstClickedStateBackColor = clickedButton.BackColor = Color.Lime;
                    stateColors.CurrentState = ButtonState.SecondClicked;
                    break;

                case ButtonState.SecondClicked:
                    stateColors.SecondClickedStateForeColor = clickedButton.ForeColor = Color.Black;
                    stateColors.SecondClickedStateBackColor = clickedButton.BackColor = Color.Yellow;
                    stateColors.CurrentState = ButtonState.Initial;
                    break;
            }
        }

        private void RestoreButtonColors()
        {
            foreach (var button in allButtons)
            {
                string buttonName = button.Name;
                if (buttonStates.ContainsKey(buttonName))
                {
                    ButtonStateColors stateColors = buttonStates[buttonName];
                    switch (stateColors.CurrentState)
                    {
                        case ButtonState.Initial:
                            button.ForeColor = stateColors.SecondClickedStateForeColor;
                            button.BackColor = stateColors.SecondClickedStateBackColor;
                            break;
                        case ButtonState.FirstClicked:
                            button.ForeColor = stateColors. InitialStateForeColor;
                            button.BackColor = stateColors. InitialStateBackColor;
                            break;
                        case ButtonState.SecondClicked:
                            button.ForeColor = stateColors.FirstClickedStateForeColor;
                            button.BackColor = stateColors.FirstClickedStateBackColor;
                            break;
                    }
                }
            }
        }

        public class ButtonStateColors
        {
            public ButtonState CurrentState { get; set; } = ButtonState.Initial;

            public Color InitialStateForeColor { get; set; }
            public Color InitialStateBackColor { get; set; }
            public Color FirstClickedStateForeColor { get; set; }
            public Color FirstClickedStateBackColor { get; set; }
            public Color SecondClickedStateForeColor { get; set; }
            public Color SecondClickedStateBackColor { get; set; }
        }
        public enum ButtonState
        {
            Initial = 0,
            FirstClicked = 1,
            SecondClicked = 2,
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Serialize the buttonStates dictionary to a JSON string
            string buttonStateJson = Newtonsoft.Json.JsonConvert.SerializeObject(buttonStates);

            // Save the JSON string to the application settings
            Properties.Settings.Default.ButtonState = buttonStateJson;
            Properties.Settings.Default.Save();
        }
    }
}