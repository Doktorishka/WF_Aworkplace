﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Aworkplace.Controller.Interfaces;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Controller
{
    public class LiteratureFromReader: ILiteratureFromReader
    {
        private int id { get; set; }
        public TypeLiterature literature { get; set; }
        public TypeReader reader { get; set; }
        private DateTime dateInput { get; set; }
        private DateTime dateOutput { get; set; }
        bool idInput { get; set; }

        public static string pathFile = "../../../Files/OutputLiterature.txt";
        public int ID { get => id; set => value = id; }
        public DateTime DateInput { get => dateInput; set => value = dateInput; }
        public DateTime DateOutput { get => dateOutput; set => value = dateOutput; }

        public LiteratureFromReader() { }

        public void inputLiterature() //Update()
        {
            idInput = false;
            string[] allReader = File.ReadAllLines(pathFile);

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(';');
                if (this.ID == Convert.ToInt32(line[0]))
                {
                    allReader[i] = ID.ToString() + ";" + literature.ID + ";" + reader.ID + ";" + DateInput + ";" + dateOutput + ";" + idInput.ToString();
                }
            }
            File.WriteAllLines(Reader.pathFileReaderString, allReader);

            string lastLine = File.ReadLines(pathFile).Last();
            string[] ident = lastLine.Split(';');
        }

        public void outputLiterature() //Add()
        {
            idInput = true;
            string lastLine = File.ReadLines(pathFile).Last();
            string[] ident = lastLine.Split(';');
            string output = (Convert.ToInt32(ident[0]) + 1).ToString() + ";" + literature.ID + ";" + reader.ID + ";" + DateTime.Now.ToShortDateString() + ";" + dateOutput + ";" + idInput.ToString();
            File.AppendAllText(pathFile, output);
        }

    }
}
