using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_MVC.Models
{
    public class ThongTinMe
    {
        public int ThongTinMeID { get; set; }

        public string ThongTinMeCode { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Begom { get; set; }
        public string CycloTron { get; set; }
        public string Belang { get; set; }
        public string BomHoaChat { get; set; }
        public string BeDieuHoa { get; set; }
        public string BeSBR1 { get; set; }
        public string BeSBR2 { get; set; }
        public string MayEpBun { get; set; }

        /// <summary>
        /// INFO ME
        /// </summary>
        public string identityIdMe { get; set; }
        public int idMe { get; set; }
        public DateTime dayTimeFrom { get; set; }
        public DateTime dayTimeTo { get; set; }
        public string userUpdateMe { get; set; }
        public DateTime timeUpdateMe { get; set; }

        /// <summary>
        /// Thông tin chính của mẻ
        /// </summary>
        public string begomPh { get; set; }
        public string begomHoahocCod { get; set; }
        public string begomHoahocTss { get; set; }
        public string begomHoahocNt { get; set; }
        public string begomHoahocP { get; set; }
        public DateTime begomTimeBom { get; set; }

        /// <summary>
        /// Cyclo trộn của mẻ
        /// </summary>
        public DateTime cyclotronTimeXaday { get; set; }

        /// <summary>
        /// Bể lắng của mẻ
        /// </summary>
        public DateTime belangTimeXaday { get; set; }

        /// <summary>
        /// Bơm hoá chất của mẻ
        /// </summary>
        public string bomhoachatNongdo { get; set; }
        public DateTime bomhoachatTimeBom { get; set; }

        /// <summary>
        /// Bể điều hoà của mẻ
        /// </summary>
        public string bedieuhoaDo { get; set; }
        public DateTime bedieuhoaTimeBom { get; set; }
        public DateTime bedieuhoaTimeThoikhi { get; set; }

        /// <summary>
        /// Bể SBR của mẻ
        /// </summary>
        public string besbr1Ph { get; set; }
        public string besbr1Do { get; set; }
        public string besbr1HoahocCod { get; set; }
        public string besbr1HoahocTss { get; set; }
        public string besbr1HoahocNt { get; set; }
        public string besbr1HoahocP { get; set; }
        public string besbr1Vl { get; set; }
        public DateTime besbr1TimeLamday { get; set; }
        public DateTime besbr1TimeXuly { get; set; }
        public DateTime besbr1TimeLang { get; set; }
        public DateTime besbr1TimeXa { get; set; }
        public DateTime besbr1TimeCho { get; set; }
        public DateTime besbr1TimeBombun { get; set; }

        /// <summary>
        /// Bể SBR 2 của mẻ
        /// </summary>
        public string besbr2Ph { get; set; }
        public string besbr2Do { get; set; }
        public string besbr2HoahocCod { get; set; }
        public string besbr2HoahocTss { get; set; }
        public string besbr2HoahocNt { get; set; }
        public string besbr2HoahocP { get; set; }
        public string besbr2Vl { get; set; }
        public DateTime besbr2TimeLamday { get; set; }
        public DateTime besbr2TimeXuly { get; set; }
        public DateTime besbr2TimeLang { get; set; }
        public DateTime besbr2TimeXa { get; set; }
        public DateTime besbr2TimeCho { get; set; }
        public DateTime besbr2TimeBombun { get; set; }

        /// <summary>
        /// Máy ép bùn của mẻ
        /// </summary>
        public DateTime mayepbunTimeHoatdong { get; set; }
        public string mayepbunKhoiluongbunkho { get; set; }

    }
}