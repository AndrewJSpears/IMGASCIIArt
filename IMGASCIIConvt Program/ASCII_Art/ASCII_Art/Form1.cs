using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ASCII_Art
{
   public partial class Form1 : Form
   {

      Bitmap bitmap, bitmapOriginal;
      string inputFile;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         greenTrackBar.SetRange(0, 255);
         redTrackBar.SetRange(0, 255);
         blueTrackBar.SetRange(0, 255);
      }

      private void btnSearch_Click(object sender, EventArgs e)
      {
         imgPreview.Image = null;

         try
         {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               fileLocation.Text = openFileDialog.FileName.ToString();
               inputFile = fileLocation.Text;
            }
            bitmapOriginal = new Bitmap(inputFile, true);
            bitmap = new Bitmap(inputFile, true);

            imgPreview.Image = bitmap;
            greyScaleBox.Image = bitmap;
         }
         catch (Exception exception)
         {
            MessageBox.Show(exception.Message);
            return;
         }
      }

      /// <summary>
      /// Converts the gray scale image to ASCII art (output file)
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void btnConvert_Click(object sender, EventArgs e)
      {
         //more efficient than string concat...
         StringBuilder newString = new StringBuilder();        

      }

      #region Gray_scale_options
      /// <summary>
      /// Utilizes light sensitivity to RGB colors for conversion to gray scale
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void rdioBtn1_CheckedChanged(object sender, EventArgs e)
      {
         // DialogResult message = new MessageBox("Please Wait \nFor Process \nTo Complete",

         if (rdioBtnAvg.Checked == true)
         {
            rdioBtnAvg.Checked = false;
            //insert old image (not black and white, and call to change red/green/blue values of image again) or store B&W version...
            return;
         }
         

         //greyScaleBox.Dispose();
         //Average
         //convert image to gray scale (Average) TODO: offer lightness & average
         for (int x = 0; x < bitmap.Width; x++)
         {
            for (int y = 0; y < bitmap.Height; y++)
            {
               Color color = bitmap.GetPixel(x, y);
               int greyConversion = (color.R + color.G + color.B) / 3;
               Color greyColor = Color.FromArgb(color.A, greyConversion, greyConversion, greyConversion);
               bitmap.SetPixel(x, y, greyColor);
            }
         }
         greyScaleBox.Image = bitmap;
         
      }



      //private void rdioBtn2_CheckedChanged(object sender, EventArgs e)
      //{

      //   //Lightness 
      //   //convert image to gray scale (Lightness) TODO: offer lightness & average
      //   for (int x = 0; x < bitmap.Width; x++)
      //   {
      //      for (int y = 0; y < bitmap.Height; y++)
      //      {
      //         Color color = bitmap.GetPixel(x, y);
      //         int greyConversion = ((Math.Max(color.R, Math.Max(color.G, color.B)) + Math.Min(color.R, Math.Min(color.G, color.B))) / 2);
      //         Color greyColor = Color.FromArgb(color.A, greyConversion, greyConversion, greyConversion);
      //         bitmap.SetPixel(x, y, greyColor);
      //      }
      //   }
      //   greyScaleBox.Image = bitmap;
      //}

      //private void rdioBtn3_CheckedChanged(object sender, EventArgs e)
      //{

      //   //Luminosity
      //   //convert image to gray scale (luminosity) TODO: offer lightness & average
      //   for (int x = 0; x < bitmap.Width; x++)
      //   {
      //      for (int y = 0; y < bitmap.Height; y++)
      //      {
      //         Color color = bitmap.GetPixel(x, y);
      //         int greyConversion = (int)((color.R * .21) + (color.G * .72) +
      //            (color.B * .07));
      //         Color greyColor = Color.FromArgb(color.A, greyConversion, greyConversion, greyConversion);
      //         bitmap.SetPixel(x, y, greyColor);
      //      }
      //   }
      //   greyScaleBox.Image = bitmap;
      //}
      #endregion

      private void redTrackBar_MouseUp(object sender, MouseEventArgs e)
      {
        SetRedValue(redTrackBar.Value);
      }

      private void SetRedValue(int redValue)
      {
         for (int x = 0; x < bitmap.Width; x++)
         {
            for (int y = 0; y < bitmap.Height; y++)
            {
               Color color = bitmap.GetPixel(x, y);
               //int greyConversion = (color.R + color.G + color.B) / 3;
               Color greyColor = Color.FromArgb(color.A, redValue, color.B, color.G);
               bitmap.SetPixel(x, y, greyColor);
            }
         }
         greyScaleBox.Image = bitmap;
      }

      private void greenTrackBar_MouseUp(object sender, MouseEventArgs e)
      {
         SetGreenValue(greenTrackBar.Value);
      }

      void SetGreenValue(int greenValue)
      {
         for (int x = 0; x < bitmap.Width; x++)
         {
            for (int y = 0; y < bitmap.Height; y++)
            {
               Color color = bitmap.GetPixel(x, y);
               //int greyConversion = (color.R + color.G + color.B) / 3;
               Color greyColor = Color.FromArgb(color.A, color.R, color.B, greenValue);
               bitmap.SetPixel(x, y, greyColor);
            }
         }
         greyScaleBox.Image = bitmap;
      }

      private void blueTrackBar_MouseUp(object sender, MouseEventArgs e)
      {
         SetBlueValue(greenTrackBar.Value);

      }

      void SetBlueValue(int blueValue)
      {
         for (int x = 0; x < bitmap.Width; x++)
         {
            for (int y = 0; y < bitmap.Height; y++)
            {
               Color color = bitmap.GetPixel(x, y);
               //int greyConversion = (color.R + color.G + color.B) / 3;
               Color greyColor = Color.FromArgb(color.A, color.R, blueValue, color.G);
               bitmap.SetPixel(x, y, greyColor);
            }
         }
         greyScaleBox.Image = bitmap;
      }

      private void freshImage_Click(object sender, EventArgs e)
      {
         greyScaleBox.Image = null;
         greyScaleBox.Image = bitmapOriginal;
      }
   }
}
