﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WM.Core.Optimization;
using WM.Northwind.Entities.ComplexTypes.EczaneNobet;
using WM.Northwind.Entities.Concrete.EczaneNobet;

namespace WM.Northwind.Entities.Concrete.Optimization.EczaneNobet
{
    public class MersinMerkezDataModelV2 : IDataModel
    {
        public MersinMerkezDataModelV2()
        {
            CozumItereasyon = new CozumItereasyon();
        }

        public int Yil { get; set; }
        public int Ay { get; set; }
        public int NobetUstGrupId { get; set; }

        public int LowerBound { get; set; }
        public int UpperBound { get; set; }
        public int CalismaSayisi { get; set; }
        public DateTime NobetUstGrupBaslangicTarihi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        public List<EczaneGrupDetay> EczaneGruplar { get; set; }
        public List<EczaneGrupDetay> OncekiAylardaAyniGunNobetTutanEczaneler { get; set; }
        public List<EczaneGrupDetay> ArasindaAyniGun2NobetFarkiOlanIkiliEczaneler { get; set; }
        public List<EczaneGrupDetay> AltGruplarlaAyniGunNobetTutmayacakEczanelerYenisehir1_2 { get; set; }
        public List<EczaneGrupDetay> AltGruplarlaAyniGunNobetTutmayacakEczanelerYenisehir3_2 { get; set; }
        public List<EczaneGrupDetay> AltGruplarlaAyniGunNobetTutmayacakEczanelerToroslar { get; set; }

        public List<EczaneGrupTanimDetay> EczaneGrupTanimlar { get; set; }
        public List<EczaneNobetIstatistik> EczaneKumulatifHedefler { get; set; }
        public List<EczaneNobetIstatistik> EczaneNobetIstatistikler { get; set; }
        public List<EczaneNobetMazeretDetay> EczaneNobetMazeretler { get; set; }
        public List<EczaneNobetIstekDetay> EczaneNobetIstekler { get; set; }
        public List<TakvimNobetGrup> TarihAraligi { get; set; }
        public List<NobetGrupDetay> NobetGruplar { get; set; }
        public List<NobetGrupKuralDetay> NobetGrupKurallar { get; set; }
        public List<NobetGrupGunKuralDetay> NobetGrupGunKurallar { get; set; }
        public List<NobetGrupGorevTipDetay> NobetGrupGorevTipler { get; set; }
        public List<NobetGrupTalepDetay> NobetGrupTalepler { get; set; }
        public List<EczaneNobetGrupDetay> EczaneNobetGruplar { get; set; }
        public List<EczaneNobetGrupAltGrupDetay> EczaneNobetGrupAltGruplar { get; set; }

        public List<NobetUstGrupKisitDetay> Kisitlar { get; set; }

        public List<EczaneNobetSonucListe2> EczaneGrupNobetSonuclar { get; set; }//EczaneGrupNobetSonuc
        public List<EczaneNobetSonucListe2> EczaneNobetSonuclar { get; set; }//EczaneNobetSonucListe2
        public List<EczaneNobetSonucListe2> EczaneGrupNobetSonuclarTumu { get; set; }

        public List<EczaneNobetGrupGunKuralIstatistik> EczaneNobetGrupGunKuralIstatistikler { get; set; }
        public List<TakvimNobetGrupGunDegerIstatistik> TakvimNobetGrupGunDegerIstatistikler { get; set; }
        public List<EczaneNobetGrupGunKuralIstatistikYatay> EczaneNobetGrupGunKuralIstatistikYatay { get; set; }
                
        public CozumItereasyon CozumItereasyon { get; set; }
        
        //Karar Değişkenleri
        public List<EczaneNobetTarihAralik> EczaneNobetTarihAralik { get; set; }
        public List<EczaneNobetAltGrupTarihAralik> EczaneNobetAltGrupTarihAralik { get; set; }
        //public List<EczaneNobetSonucListe2> EczaneNobetSonuclarAltGruplarlaBirlikte { get; set; }
        public List<EczaneNobetTarihAralikIkili> EczaneNobetTarihAralikIkiliEczaneler { get; set; }
        public List<AyniGunTutulanNobetDetay> IkiliEczaneler { get; set; }
        public List<EczaneGrupDetay> SonrakiDonemAyniGunNobetIstekGirilenler { get; set; }
        public List<NobetGrupGorevTipKisitDetay> NobetGrupGorevTipKisitlar { get; set; }
        public int CalismaSayisiLimit { get; set; }
        public int TimeLimit { get; set; }
        public List<KalibrasyonYatay> Kalibrasyonlar { get; set; }
        public List<EczaneNobetGrupGunKuralIstatistikYatay> EczaneNobetGrupGunKuralIstatistikYataySon3Ay { get; set; }
        public List<DebugEczaneDetay> DebugYapilacakEczaneler { get; set; }
    }
}
