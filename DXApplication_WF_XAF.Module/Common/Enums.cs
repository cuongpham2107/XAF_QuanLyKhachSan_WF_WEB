using DevExpress.ExpressApp.DC;
using System;
using System.Linq;

namespace DXApplication_WF_XAF.Module.Common
{

    public class Enums
    {
        public enum TrangThaiDatPhong
        {
            [XafDisplayName("Lưu tạm")] luutam = 0,
            [XafDisplayName("Đang cho thuê")] dangchothue = 1,
            [XafDisplayName("Đã trả phòng")] datraphong = 2,

        }
    }

}
