﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num; 
            ////bool res = int.TryParse("1985", out num);

            //if (int.TryParse("1985", out num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão";
            //}
            #endregion

            #region ToString / Convert.ToString
            //double num = 120.5;
            //lblResultado.Text = num.ToString("00000.00");
            //int num = 254;
            ////lblResultado.Text = num.ToString("X"); //Hex
            ////lblResultado.Text = num.ToString("D"); //Dec
            ////lblResultado.Text = num.ToString("C"); //Monetario
            ////lblResultado.Text = num.ToString("X2"); //Hex min 2 digitos
            ////lblResultado.Text = num.ToString("D5"); //Dec min 2 digitos
            ////lblResultado.Text = num.ToString("C"); //Monetario
            //lblResultado.Text = Convert.ToString(num, 10);
            #endregion

            #region Classe Math
            //double pi = Math.PI;
            //double E = Math.E;
            //double seno = Math.Sin(3);
            //double conseno = Math.Cos(3);
            //double potencia = Math.Pow(2, 2);
            //double raizQuadrada = Math.Sqrt(49);
            //double  arendonda = Math.Round(158.75);
            //double inteiro = Math.Truncate(32.57);
            //double floor = Math.Floor(52.75);
            //double ceil = Math.Ceiling(52.25);
            //lblResultado.Text = ceil.ToString("#.00");
            #endregion

        }
    }
}
