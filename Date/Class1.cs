using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class DateClass
    {
        /*Implementirati svoju klasu „Date“ (ne koristiti funkcionalnosti ugrađene Date klase!) koja omogućava rad s datumima.
         * Konstruktor klase prima godinu, mjesec i dan kao int. Klasa mora podržati slijedeće funkcionalnosti: getMonthName,
         * getNumberOfRemaingDaysInMonth, isLeapYear (prijestupne godine su sve djeljive s 4, ako nisu djeljive sa 100, kojima 
         * se dodaju one koju su djeljive sa 400, npr 2000-ta je prijestupna iako je djeljiva sa 100, jer je djeljiva sa 400). 
         * Napraviti unit-testove koji postižu potpunu pokrivenost koda.*/

        public DateClass()
        {
            Dan = 1;
            Mjesec = 1;
            Godina = 1;
        }
        private int godina;
        private int mjesec;
        private int dan;
        public int Godina { get{return godina;} set{godina=value;} }
        public int Mjesec { get { return mjesec; } set { mjesec = value; } }
        public int Dan { get{return dan;} set{dan=value;} }

        public DateClass(int d,int m,int g)
        {
            this.Dan = d;
            this.Mjesec = m;
            this.Godina = g;
        }
        public string getMounthName(int mjesec)
        {
            String mjes="";
            if (mjesec == 1)
                mjes = "Siječanj";
            else if (mjesec == 2)
                mjes = "Veljača";
            else if (mjesec == 3)
                mjes = "Ožujak";
            else if (mjesec == 4)
                mjes = "Travanj";
            else if (mjesec == 5)
                mjes = "Svibanj";
            else if (mjesec == 6)
                mjes = "Lipanj";
            else if (mjesec == 7)
                mjes = "Srpanj";
            else if (mjesec == 8)
                mjes = "Kolovoz";
            else if (mjesec == 9)
                mjes = "Rujan";
            else if (mjesec == 10)
                mjes = "Listopad";
            else if (mjesec == 11)
                mjes = "Studeni";
            else if (mjesec == 12)
                mjes = "Prosinac";

            return mjes;
        }
        public int getNumberOfRemaingDaysInMonth(int dan,int mjesec,int godina)
        {
            int broj=0;
            if(mjesec==1 || mjesec==3 || mjesec==5 || mjesec==7 || mjesec==8 || mjesec==10 || mjesec==12)
                broj=31-dan;
            else if(mjesec==4 || mjesec==6 || mjesec==9 || mjesec==11)
                broj=30-dan;
            else if(isLeapYear(godina))
                broj=29-dan;
            else
                broj=28-dan;
            return broj;
        }
        public Boolean isLeapYear(int godina)
        {
            Boolean JeLi=false;
            if (godina % 400 == 0)
                JeLi = true;
            else if (godina % 100 == 0)
                JeLi = false;
            else if (godina % 4 == 0)
                JeLi = true;
            else
                JeLi = false;

            return JeLi;
        }

    }
}
