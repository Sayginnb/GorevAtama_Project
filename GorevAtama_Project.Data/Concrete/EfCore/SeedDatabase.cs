using GorevAtama_Project.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Data.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new GorevAtama_ProjectContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Personels.Count() == 0)
                {
                    context.Personels.AddRange(Personels);
                }
                if (context.Rols.Count() == 0)
                {
                    context.Rols.AddRange(Rols);
                }
                if (context.Islems.Count() == 0)
                {
                    context.Islems.AddRange(Islems);
                }
                context.SaveChanges();
            }
        }
        private static Rol[] Rols =
{
            new Rol() {RolAd="Rol1"},
            new Rol() {RolAd="Rol2"},
            new Rol() {RolAd="Rol3"},
            new Rol() {RolAd="Rol4"},
            new Rol() {RolAd="Rol5"},
            new Rol() {RolAd="Rol6"},
            new Rol() {RolAd="Rol7"},
            new Rol() {RolAd="Rol8"}
        };
        private static Islem[] Islems =
        {
            new Islem() {IslemAd="işlem1", IslemZorluk="1"},
            new Islem() {IslemAd="işlem2", IslemZorluk="2"},
            new Islem() {IslemAd="işlem3", IslemZorluk="3"},
            new Islem() {IslemAd="işlem4", IslemZorluk="4"},
            new Islem() {IslemAd="işlem5", IslemZorluk="5"},
            new Islem() {IslemAd="işlem6", IslemZorluk="6"},
            new Islem() {IslemAd="işlem7", IslemZorluk="7"},
            new Islem() {IslemAd="işlem8", IslemZorluk="8"}
        };
        private static Personel[] Personels =
        {
            new Personel() {PersonelAd = "Beyza", PersonelSoyad="Dursun",Rol=Rols[0], Islem=Islems[0]},
            new Personel() {PersonelAd = "Beyza1", PersonelSoyad="Dursun1",Rol=Rols[1], Islem=Islems[1]},
            new Personel() {PersonelAd = "Beyza2", PersonelSoyad="Dursun2",Rol=Rols[2], Islem=Islems[2]},
            new Personel() {PersonelAd = "Beyza3", PersonelSoyad="Dursun3",Rol=Rols[3], Islem=Islems[3]},
            new Personel() {PersonelAd = "Beyza4", PersonelSoyad="Dursun4",Rol=Rols[4], Islem=Islems[4]},
            new Personel() {PersonelAd = "Beyza5", PersonelSoyad="Dursun5",Rol=Rols[5], Islem=Islems[5]},
            new Personel() {PersonelAd = "Beyza6", PersonelSoyad="Dursun6",Rol=Rols[6], Islem=Islems[6]},
            new Personel() {PersonelAd = "Beyza7", PersonelSoyad="Dursun7",Rol=Rols[7], Islem=Islems[7]}
        };

    }
}
