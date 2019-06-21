using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson7
{
    public partial class HelloWorld : Form
    {
        /// <summary>
        /// HelloWorld Form Constructor
        /// </summary>
        public HelloWorld()
        {
            InitializeComponent();
            Start();
        }

        /// <summary>
        /// This method is used for initialization purposes
        /// </summary>
        public void Start()
        {
            HelloWorldLabel.Text = "Hello, Tom!";
            HelloWorldLabel.BackColor = Color.Black;
            HelloWorldLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// Event Handler for the ClickMeButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = (HelloWorldLabel.Text == "Clicked!") ? "Unclicked!" : "Clicked!";
        }
    }
}
