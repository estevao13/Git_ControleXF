﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    public partial class SearchBarPage : ContentPage
    {
        private List<String> empresasTI;

        public SearchBarPage()
        {
            InitializeComponent();

            empresasTI = new List<string>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Aplle");
            empresasTI.Add("Oracle");
            empresasTI.Add("IBM");
            empresasTI.Add("SAP");
            empresasTI.Add("Uber");
            empresasTI.Add("99Taxi");

            Preencher(empresasTI);
        }

        private void PesquisaB(Object sender, EventArgs args)
        {
            var resultado = empresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();
            Preencher(resultado);
        }

        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = empresasTI.Where(a => a.Contains(args.NewTextValue)).ToList<String>();

            Preencher(resultado);
        }
        private void Preencher(List<String> empresasTI)
        {
            ListResult.Children.Clear();
            foreach (var emp in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = emp });
            }
        }

    }
}

