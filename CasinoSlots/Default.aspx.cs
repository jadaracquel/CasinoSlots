using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CasinoSlots
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPullLevel_Click(object sender, EventArgs e)
        {
            int cherryCt = 0, horseshoeCt = 0;
            Random rand = new Random();
            int[] options = new int[3];
            Image[] myImages = new Image[3] { Image1, Image2, Image3 };

            //check to make sure the users input can be converted into an integer
            if (!int.TryParse(txbxBet.Text, out int bet)) //if it can't be converted
            {
                lblResult.Text = "Only integers allowed! Try again...";
                lblMoney.Text = "";
                return;
            }
            else
            {
                lblResult.Text = "";
            }

            for (int i = 0; i < myImages.Length; i++)
            {
                options[i] = rand.Next(0, 3);   //randomly generates a number between 0 and 3 ==> (0, 1, or 2)

                switch (options[i])
                {
                    case 0:     // 0 ==> shamrock
                        myImages[i].ImageUrl = "/Images/shamrock.jpg";
                        break;
                    case 1:     //1 ==> cherry
                        myImages[i].ImageUrl = "/Images/cherry.png";
                        cherryCt++;
                        break;
                    case 2:     //2 ==> horseshoe
                        myImages[i].ImageUrl = "/Images/horseshoe.jpg";
                        horseshoeCt++;
                        break;
                }
            }
            CalculateReward(bet, cherryCt, horseshoeCt);
        }

        private void CalculateReward(int bet, int cherries, int horseshoes)
        {
            int reward = 0;
            if (cherries > 0)
            {
                if (cherries == 3)
                {
                    lblResult.Text = "Three Cherries";
                    reward = bet * 4;
                }
                else if (cherries == 2)
                {
                    lblResult.Text = "Two Cherries";
                    reward = bet * 3;
                }
                else if (cherries == 1)
                {
                    lblResult.Text = "One Cherry";
                    reward = bet * 2;
                }
            }
            else if (horseshoes == 3)
            {
                lblResult.Text = "JACKPOT!";
                reward = bet * 100;
            }

            lblMoney.Text = "You bet $" + txbxBet.Text + " and won $" + reward.ToString();
        }
    }
}