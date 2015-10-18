using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Ciastka : IJedz
    {
        public abstract void skladniki();
        public abstract void przygotowanie();
        public abstract void jedz();
    }

    public class Kremowka : Ciastka
    {
        private int _jedz;
        public Kremowka(int Jedz)
        {
            _jedz = Jedz;
        }
        public override void skladniki()
        {
            Console.WriteLine("Składniki na ciasto: \n- 250 g mąki \n- 250 g masła \n- 125 ml wody \n- 1 łyżeczka octu \n- szczypta soli \nSkładniki na budyń: \n- 1 l mleka \n- 1 szklanka cukru \n- cukier waniliowy \n- 1 szklanka mąki \n- 5 żółtek");
        }
        public override void przygotowanie()
        {
            Console.WriteLine("Sposób przygotowania: Mąkę, sól, wodę i ocet połącz w jednolite ciasto. Wyrób je ręcznie i włóż zawinięte w folię na 30 minut do lodówki. Następnie rozwałkuj je(najlepiej w prostokąt).Nakłuj widelcem surowe ciasto i ułóż na nim płatki porwanego masła. \nWłóż tak przygotowane ciasto na kolejne 15 minut do lodówki.Po tym czasie złóż ciasto na trzy części i znowu odstaw je do lodówki. \nCzynność należy powtórzyć około 3 - 4 razy.Następnie ciasto podziel na dwie części. Rozwałkuj każdą z nich i włóż do wysmarowanej tłuszczem blaszki. \nKażdy placek piecz około 12 minut w temperaturze 220 stopni. \nPo wyjęciu delikatnie odkrój górną część ciasta.Zrób to ostrym nożem. Ciasto nie powinno się pokruszyć, jednak dla ułatwienia możesz wycinać małe kawałki, które potem ułożysz na wierzchu ciasta. Odstaw tak podzielone ciasto do wystygnięcia. \nPrzygotuj budyń: 2 szklanki zimnego mleka miksuj z żółtkami i mąką na gładką masę.W pozostałej części mleka rozpuść cukier i cukier waniliowy. \nGotuj na wolnym ogniu, kiedy zacznie wrzeć, wlej zawiesinę z mleka i mąk. \nEnergicznie mieszaj do czasu aż budyń zgęstnieje. Odstaw go do wystygnięcia.Schłodzony budyń wylej na ciasto. Na wierzchu ułóż odkrojone ciasto./nWstaw na kilka godzin do lodówki.Przed podaniem pokrój ciasto na mniejsze porcje i posyp cukrem pudrem. \nSmacznego!");
        }
        public override void jedz()
        {
            Console.WriteLine("Zostalo " + (--_jedz) + " kremowek\n");
        }
    }
    public class Pieguski : Ciastka
    {
        private int _jedz;
        public Pieguski(int Jedz)
        {
            _jedz = Jedz;
        }
        public override void skladniki()
        {
            Console.WriteLine("Składniki: \n- 1 kostka miękkiego masła \n- 1 szklanka cukru \n- 1 jajko \n- 2, 5 szklanki mąki \n- 1 / 2 łyżeczki soli \n- 1 / 2 łyżeczki sody \n- 1, 5 tabliczki gorzkiej czekolady \n- 1 szklanka orzechów włoskich(można bez orzechów) ");
        }
        public override void przygotowanie()
        {
            Console.WriteLine("Czekoladę pokroić w kostkę, orzechy posiekać, ale dość grubo. Masło utrzeć z cukrem, dodać jajko i wymieszać.Dodać mąkę, sodę, sól i dokładnie wymieszać(można zmiksować). \nDo masy dodać orzechy i czekoladę(można podzielić i jedne zrobić z orzechami, a drugie z czekoladą).Gdy na koniec już mikser nie daje rady można ciasto wyrobić ręcznie.Piekarnik rozgrzać do temp. 200 stopni. Z masy robić małe kuleczki(wielkości orzecha włoskiego) i układać na blaszce, zachowując dość duże odstępy, ponieważ ciasteczka się rozpłyną. \nPiec 10 - 15 minut. Można dodać też mak, rodzynki czy inne bakalie albo olejek do ciast - na co kto ma ochotę. \nSmacznego! :) ");
        }
        public override void jedz()
        {
            Console.WriteLine("Zostalo " + (--_jedz) + " piegusek\n");
        }
    }
}
