using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;

namespace TelephoneDirectory.Repository.Repositories
{
    public class InstitutionRepository : GenericRepository<Institution>, IInstitutionRepository
    {
        public InstitutionRepository(AppDbContext context) : base(context)
        {
        }

        //public async Task<List<Product>> GetInstitutionsWithOtherTable()
        //{
            //var predicate = PredicateBuilder.New<sm_cihaz>();

            //predicate = predicate.And(te => te.firma_id == organizasyonId);

            //if (!string.IsNullOrEmpty(cihazSeriNo))
            //{
            //    predicate = predicate.And(te => te.serial_no.ToLower().Contains(cihazSeriNo.ToLower()));
            //}
            //if (!string.IsNullOrEmpty(kullaniciAdiSoyadi))
            //{
            //    predicate = predicate.And(te => te.kullanici_adi.ToLower().Contains(kullaniciAdiSoyadi.ToLower()));
            //}
            //if (ulkefilterid > 0)
            //{
            //    predicate = predicate.And(x => x.ulke_id == ulkefilterid);
            //}
            //if (ilfilterid > 0)
            //{
            //    predicate = predicate.And(x => x.il_id == ilfilterid);
            //}
            //if (ilcefilterid > 0)
            //{
            //    predicate = predicate.And(x => x.ilce_id == ilcefilterid);
            //}
            //if (mahallefilterid > 0)
            //{
            //    predicate = predicate.And(x => x.mahalle_id == mahallefilterid);
            //}

            //var list = (
            //from k in _unitOfWork.PersonelRepository.Table
            //from f in _unitOfWork.OrganizasyonRepository.Table
            //from d in _unitOfWork.SmCihazRepository.Table.Where(predicate).Where(a => a.kullanici_id == k.id && a.firma_id == f.id)
            //select new CihazListesi
            //{
            //    Id = d.id,
            //    SerialNo = d.serial_no,
            //    KullaniciAdi = d.kullanici_adi,
            //    Parola = d.parola,
            //    Kullanici = k.kullanici_adi,
            //    KullaniciEmail = k.email,
            //    Durumu = d.durumu,
            //    KayitZamani = d.kayit_zamani,
            //    AdiSoyadi = k.adi_soyadi,
            //    Firma = f.adi
            //}).OrderByDescending(x => x.Id).ToList();
            //return list;
        //}
    }
}
