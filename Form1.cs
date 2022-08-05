using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace vigenereASCII
{
    public partial class Form1 : Form
    {

        List<string> myLista = new List<string>();
        List<string> listaVigenere = new List<string>();
        List<int> mapeo = new List<int>();


        int cont_decrementa = 2;
        int cont_incrementa =  2;
        int indice = 0;

        Hashtable tabla1 = new Hashtable();
        Hashtable tabla2 = new Hashtable();

        public Form1()
        {
            InitializeComponent();
            inicializar_tablas();


        }
        void inicializar_tablas()
        {
            //tabla1.Add(" ", 32);
            tabla1.Add("!", 33);
            tabla1.Add("\"",34); //Checar
            tabla1.Add("#", 35);
            tabla1.Add("$", 36);
            tabla1.Add("%", 37);
            tabla1.Add("&", 38);
            tabla1.Add("'", 39); //Checar
            tabla1.Add("(", 40);
            tabla1.Add(")", 41);
            tabla1.Add("*", 42);
            tabla1.Add("+", 43);
            tabla1.Add(",", 44);
            tabla1.Add("-", 45);
            tabla1.Add(".", 46);
            tabla1.Add("/", 47);
            tabla1.Add("0", 48);
            tabla1.Add("1", 49);
            tabla1.Add("2", 50);
            tabla1.Add("3", 51);
            tabla1.Add("4", 52);
            tabla1.Add("5", 53);
            tabla1.Add("6", 54);
            tabla1.Add("7", 55);
            tabla1.Add("8", 56);
            tabla1.Add("9", 57);
            tabla1.Add(":", 58);
            tabla1.Add(";", 59);
            tabla1.Add("<", 60);
            tabla1.Add("=", 61);
            tabla1.Add(">", 62);
            tabla1.Add("¿", 63);
            tabla1.Add("@", 64);
            tabla1.Add("A", 65);
            tabla1.Add("B", 66);
            tabla1.Add("C", 67);
            tabla1.Add("D", 68);
            tabla1.Add("E", 69);
            tabla1.Add("F", 70);
            tabla1.Add("G", 71);
            tabla1.Add("H", 72);
            tabla1.Add("I", 73);
            tabla1.Add("J", 74);
            tabla1.Add("K", 75);
            tabla1.Add("L", 76);
            tabla1.Add("M", 77);
            tabla1.Add("N", 78);
            tabla1.Add("O", 79);
            tabla1.Add("P", 80);
            tabla1.Add("Q", 81);
            tabla1.Add("R", 82);
            tabla1.Add("S", 83);
            tabla1.Add("T", 84);
            tabla1.Add("U", 85);
            tabla1.Add("V", 86);
            tabla1.Add("W", 87);
            tabla1.Add("X", 88);
            tabla1.Add("Y", 89);
            tabla1.Add("Z", 90);
            tabla1.Add("[", 91);
            tabla1.Add("\\", 92);//checar
            tabla1.Add("]", 93);
            tabla1.Add("^", 94);
            tabla1.Add("_", 95);
            tabla1.Add("´", 96);
            tabla1.Add("a", 97);
            tabla1.Add("b", 98);
            tabla1.Add("c", 99);
            tabla1.Add("d", 100);
            tabla1.Add("e", 101);
            tabla1.Add("f", 102);
            tabla1.Add("g", 103);
            tabla1.Add("h", 104);
            tabla1.Add("i", 105);
            tabla1.Add("j", 106);
            tabla1.Add("k", 107);
            tabla1.Add("l", 108);
            tabla1.Add("m", 109);
            tabla1.Add("n", 110);
            tabla1.Add("o", 111);
            tabla1.Add("p", 112);
            tabla1.Add("q", 113);
            tabla1.Add("r", 114);
            tabla1.Add("s", 115);
            tabla1.Add("t", 116);
            tabla1.Add("u", 117);
            tabla1.Add("v", 118);
            tabla1.Add("w", 119);
            tabla1.Add("x", 120);
            tabla1.Add("y", 121);
            tabla1.Add("z", 122);
            tabla1.Add("{", 123);
            tabla1.Add("|", 124);
            tabla1.Add("}", 125);
            tabla1.Add("~", 126);
            tabla1.Add("ñ", 127); //extendidos
            tabla1.Add("á", 128);
            tabla1.Add("é", 129);
            tabla1.Add("í", 130);
            tabla1.Add("ó", 131);
            tabla1.Add("ú", 132);
            tabla1.Add("Á", 133);
            tabla1.Add("É", 134);
            tabla1.Add("Í", 135);
            tabla1.Add("Ó", 136);
            tabla1.Add("Ú", 137);


           // tabla2.Add(32," ");
            tabla2.Add(33, "!");
            tabla2.Add(34,"\""); //Checar
            tabla2.Add(35,"#");
            tabla2.Add(36,"$");
            tabla2.Add(37,"%");
            tabla2.Add(38, "&");
            tabla2.Add(39,"'" ); //Checar
            tabla2.Add(40,"(");
            tabla2.Add(41,")");
            tabla2.Add(42,"*");
            tabla2.Add(43,"+");
            tabla2.Add(44,",");
            tabla2.Add(45,"-");
            tabla2.Add(46,".");
            tabla2.Add(47,"/");
            tabla2.Add(48,"0");
            tabla2.Add(49,"1");
            tabla2.Add(50,"2");
            tabla2.Add(51,"3");
            tabla2.Add(52,"4");
            tabla2.Add(53,"5");
            tabla2.Add(54,"6");
            tabla2.Add(55,"7");
            tabla2.Add(56,"8");
            tabla2.Add(57,"9");
            tabla2.Add(58,":");
            tabla2.Add(59,";");
            tabla2.Add(60,"<");
            tabla2.Add(61,"=");
            tabla2.Add(62,">");
            tabla2.Add(63,"¿");
            tabla2.Add(64,"@");
            tabla2.Add(65,"A");
            tabla2.Add(66,"B");
            tabla2.Add(67,"C");
            tabla2.Add(68,"D");
            tabla2.Add(69,"E");
            tabla2.Add(70,"F");
            tabla2.Add(71,"G");
            tabla2.Add(72,"H");
            tabla2.Add(73,"I");
            tabla2.Add(74,"J");
            tabla2.Add(75,"K");
            tabla2.Add(76,"L");
            tabla2.Add(77,"M");
            tabla2.Add(78,"N");
            tabla2.Add(79,"O");
            tabla2.Add(80,"P");
            tabla2.Add(81,"Q");
            tabla2.Add(82,"R");
            tabla2.Add(83,"S");
            tabla2.Add(84,"T");
            tabla2.Add(85,"U");
            tabla2.Add(86,"V");
            tabla2.Add(87,"W");
            tabla2.Add(88,"X");
            tabla2.Add(89,"Y");
            tabla2.Add(90,"Z");
            tabla2.Add(91,"[");
            tabla2.Add(92,"\\");//checar
            tabla2.Add(93,"]");
            tabla2.Add(94,"^");
            tabla2.Add(95,"_");
            tabla2.Add(96,"´");
            tabla2.Add(97,"a");
            tabla2.Add(98,"b");
            tabla2.Add(99,"c");
            tabla2.Add(100,"d");
            tabla2.Add(101,"e");
            tabla2.Add(102,"f");
            tabla2.Add(103,"g");
            tabla2.Add(104,"h");
            tabla2.Add(105,"i");
            tabla2.Add(106,"j");
            tabla2.Add(107,"k");
            tabla2.Add(108,"l");
            tabla2.Add(109,"m");
            tabla2.Add(110,"n");
            tabla2.Add(111,"o");
            tabla2.Add(112,"p");
            tabla2.Add(113,"q");
            tabla2.Add(114,"r");
            tabla2.Add(115,"s");
            tabla2.Add(116,"t");
            tabla2.Add(117,"u");
            tabla2.Add(118,"v");
            tabla2.Add(119,"w");
            tabla2.Add(120,"x");
            tabla2.Add(121,"y");
            tabla2.Add(122,"z");
            tabla2.Add(123,"{");
            tabla2.Add(124,"|");
            tabla2.Add(125,"}");
            tabla2.Add(126,"~");
            tabla2.Add(127,"ñ"); //extendidos
            tabla2.Add(128,"á");
            tabla2.Add(129,"é");
            tabla2.Add(130,"í");
            tabla2.Add(131,"ó");
            tabla2.Add(132,"ú");
            tabla2.Add(133,"Á");
            tabla2.Add(134,"É");
            tabla2.Add(135,"Í");
            tabla2.Add(136,"Ó");
            tabla2.Add(137,"Ú");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.Default);

                while ((line = sr.ReadLine()) != null)
                {
                    richTextBox1.AppendText(line);
                    myLista.Add(line);
                    richTextBox1.AppendText("\n");
                }



                sr.Close();
            }

        }

      

        void descifrar()
        {
            int num_lineas = listaVigenere.Count;
            int i;
            string cadena = "";
            for (i = 0; i < num_lineas; i++)
            {

                cadena = listaVigenere[i];
                vigenere_inverso(cadena);

            }


        }


       

        void vigenere(string cadena)
        {
            int i = cadena.Length;
            int j;
            string cad_aux = "";
            StringBuilder cad_vigenere = new StringBuilder();

            for (j = 0; j < i; j++)
            {

                cad_aux = cadena[j].ToString();
                 if (cad_aux.ToString().Equals(" ") == false)
                    cad_vigenere.Append(recorre_caracteres(cad_aux));
                else cad_vigenere.Append(" ");
            }

            richTextBox2.AppendText(cad_vigenere.ToString());
            listaVigenere.Add(cad_vigenere.ToString());
            richTextBox2.AppendText("\n");

        }
        private void button2_Click_1(object sender, EventArgs e) //CIFRAR
        {
            int num_lineas = myLista.Count;
            int i;
            string cadena = "";
            for (i = 0; i < num_lineas; i++)
            {

                cadena = myLista[i];
                vigenere(cadena);

            }
        }

        string recorre_caracteres(string caracter)
        {
            string result = "";
            string pos_cad;
            int index;
            pos_cad = tabla1[caracter].ToString();

            index = int.Parse(pos_cad);


            index = 3*index + 2;   //3*x + 2
            mapeo.Add(index);
            if (index > 137) 
            {
              index= decrementa(index);

            }

          

            result = tabla2[index].ToString();


            return result;
        }

        int decrementa(int indexx)
        {
            int index = indexx;
            index = index - 137;
            index = index + 32;

            if (index < 138)
                return index;
            else
                return decrementa(index);        
        }


     
       

        

        private void button4_Click_1(object sender, EventArgs e) //DECIFRAR
        {
            richTextBox2.AppendText("\n");
            int num_lineas = listaVigenere.Count;
            int i;
            string cadena = "";
            for (i = 0; i < num_lineas; i++)
            {

                cadena = listaVigenere[i];
                vigenere_inverso(cadena);

            }

        }
        void vigenere_inverso(string cadena)
        {

            int i = cadena.Length;
            int j;
            string cad_aux = "";
            StringBuilder cad_vigenere = new StringBuilder();

            for (j = 0; j < i; j++)
            {

                cad_aux = cadena[j].ToString();
                if (cad_aux.ToString().Equals(" ") == false)
                    cad_vigenere.Append(recorre_caracteres_inverso(cad_aux));
                else cad_vigenere.Append(" ");
            }

            richTextBox2.AppendText(cad_vigenere.ToString());
            richTextBox2.AppendText("\n");




        }

        string recorre_caracteres_inverso(string caracter)
        {
            string result = "";
           // string pos_cad;
            int index;
           // pos_cad = tabla1[caracter].ToString();
            index = mapeo[indice];
            //index = int.Parse(pos_cad);
            index = (index - 2) / 3;   //funcion inversa
            //if (index < 32)
            //{
            //    index = incrementa(index);

            //}


            result = tabla2[index].ToString();

            indice++;
            return result;


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int i = listaVigenere.Count;
                int j = 0;
                System.IO.Stream fileStream = saveFileDialog1.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                while (i > 0)
                {
                    sw.WriteLine(listaVigenere[j]);
                    i--;
                    j++;
                }
                sw.Flush();
                sw.Close();
                // richTextBox2.SaveFile(saveFileDialog1.FileName);


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {string cad= "\\";
        MessageBox.Show(cad);
        }

      


    }
}
