using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace RoomWalkerEditor
{
    public partial class Form1 : Form
    {
        private int colNum;
        private int rowNum;
        private bool rowSub;
        private bool colSub;
        private String outFileName;

        private int[,] mapArr;

        public Form1()
        {
            InitializeComponent();

            colNum = 0;
            rowNum = 0;
            rowSub = false;
            colSub = false;

            btnGenerate.Enabled = false;
            btnExport.Enabled = false;
            btnExportName.Enabled = false;


        }

        private void newPic_Click(object sender, EventArgs e)
        {
            // Converting the sender object to a PictureBox
            PictureBox tempPic = (PictureBox)sender;

            // Creating a temporary array to store the picture coordinates
            string[] tempArr = tempPic.Name.Split(' ');
            String newString = "";

            if (tempArr[0].Equals("0"))
            {

                tempPic.Image = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\RoomTiles\floor.png");

                tempArr[0] = "1";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 1;

            }
            else if (tempArr[0].Equals("1"))
            {

                tempPic.Image = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\RoomTiles\open.png");

                tempArr[0] = "2";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 2;


            }
            else if (tempArr[0].Equals("2"))
            {

                tempPic.Image = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\RoomTiles\torch.png");

                tempArr[0] = "3";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 3;

            }
            else if (tempArr[0].Equals("3"))
            {
                tempPic.Image = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\RoomTiles\table.png");

                tempArr[0] = "4";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 4;

            }
            else if (tempArr[0].Equals("4"))
            {

                 tempPic.Image = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\RoomTiles\table2.png");

                tempArr[0] = "5";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 5;

            }
            else if (tempArr[0].Equals("5"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\BookShelf1.png");

                tempArr[0] = "6";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 6;

            }
            else if (tempArr[0].Equals("6"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\BookShelf2.png");

                tempArr[0] = "7";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 7;

            }
            else if (tempArr[0].Equals("7"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\BookShelf3.png");

                tempArr[0] = "8";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 8;

            }
            else if (tempArr[0].Equals("8"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\BookShelf4.png");

                tempArr[0] = "9";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 9;

            }
            else if (tempArr[0].Equals("9"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\pillar.png");

                tempArr[0] = "10";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 10;

            }
            else if (tempArr[0].Equals("10"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\poolWater.png");

                tempArr[0] = "11";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 11;

            }
            else if (tempArr[0].Equals("11"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\poolHealth.png");

                tempArr[0] = "12";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 12;

            }
            else if (tempArr[0].Equals("12"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\poolMagic.png");

                tempArr[0] = "13";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 13;

            }
            else if (tempArr[0].Equals("13"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\WallTorchEast.png");

                tempArr[0] = "14";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 14;

            }
            else if (tempArr[0].Equals("14"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\WallTorchWest.png");

                tempArr[0] = "15";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 15;

            }
            else if (tempArr[0].Equals("15"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\WallTorchNorth.png");

                tempArr[0] = "16";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 16;

            }
            else if (tempArr[0].Equals("16"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\WallTorchSouth.png");

                tempArr[0] = "17";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 17;

            }
            else if (tempArr[0].Equals("17"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\Start.png");

                tempArr[0] = "18";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 18;

            }
            else if (tempArr[0].Equals("18"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\End.png");

                tempArr[0] = "19";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 19;

            }
            else if (tempArr[0].Equals("19"))
            {

                tempPic.Image = Image.FromFile
               (System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\RoomTiles\wall.png");

                tempArr[0] = "0";

                newString += tempArr[0] + " " + tempArr[1] + " " + tempArr[2];

                tempPic.Name = newString;

                mapArr[Convert.ToInt32(tempArr[1]), Convert.ToInt32(tempArr[2])] = 0;

            }


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {


            int xLoc = 10;
            int yLoc = 30;

            mapArr = new int[rowNum, colNum];


            for (int x = 0; x < colNum; x++)
            {
                
                for (int y = 0; y < rowNum; y++)
                {
                    PictureBox newPic = new PictureBox();/**/

                    newPic.Click += new EventHandler(newPic_Click);/**/

                    newPic.Name = (0.ToString() + ' ' + x.ToString() + ' ' + y.ToString());

                    newPic = LoadNewPict(newPic);/**/
                    newPic.Size = new Size(50, 50);/**/
                    newPic.Location = new Point(xLoc, yLoc);/**/
                    xLoc += 50;/**/
                    panel1.Controls.Add(newPic);/**/


                    mapArr[x, y] = 0;



                }


                yLoc += 50;
                xLoc = 10;
                
            }

            btnGenerate.Enabled = false;
            btnExportName.Enabled = true;

        }

        private PictureBox LoadNewPict(PictureBox pic)
        {
            // You should replace the bold image   
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path.  
            pic.Image = Image.FromFile
            (System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal)
            + @"\RoomTiles\wall.png");

            return pic;
        }

        private void btnSubRow_Click(object sender, EventArgs e)
        {
            try
            {
                rowNum = Convert.ToInt32(txtRows.Text);

                if (rowNum > 0)
                {
                    rowSub = true;
                    btnSubRow.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid Data! \n Please enter an integer greater than 0.",
                                    "Error!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Data! \n Please enter an integer.",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            if( rowSub && colSub)
            {
                btnGenerate.Enabled = true;
            }

        }

        private void btnSubCol_Click(object sender, EventArgs e)
        {
            try
            {
                colNum = Convert.ToInt32(txtColumns.Text);

                if (colNum > 0)
                { 
                    colSub = true;
                    btnSubCol.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid Data! \n Please enter an integer greater than 0.",
                                    "Error!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Data! \n Please enter an integer.",
                                "Error!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            if (rowSub && colSub)
            {
                btnGenerate.Enabled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            StreamWriter oSW = new StreamWriter(outFileName);

            oSW.Write(rowNum);
            oSW.Write(' ');
            oSW.WriteLine(colNum);

            int x = 0;
            int y = 0;

            for (int i = 0; i < rowNum * colNum; i++)
            {

                oSW.Write(mapArr[x, y]);
                oSW.Write(' ');
                oSW.Write(y);
                oSW.Write(' ');
                oSW.Write(x);

                x++;
                oSW.WriteLine();
                if (x >= rowNum)
                { 
                    y++;
                    x = 0;
                }
            }

                /*
                for (int x = 0; x < rowNum; x++)
                {
                    for (int y = 0; y < colNum; y++)
                    {
                        oSW.Write(mapArr[x,y]);
                        oSW.Write(' ');
                    }
                    oSW.WriteLine();
                }
                */
                oSW.Close();

            btnExport.Enabled = false;
        }

        private void btnExportName_Click(object sender, EventArgs e)
        {
            if(txtExport.Text != "")
            {
                btnExport.Enabled = true;
                btnExportName.Enabled = false;
                outFileName = txtExport.Text;
            }
        }
    }
}
