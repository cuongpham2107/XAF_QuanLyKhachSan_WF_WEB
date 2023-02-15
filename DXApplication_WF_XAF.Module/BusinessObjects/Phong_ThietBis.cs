using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace DXApplication_WF_XAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Phong_ThietBis : BaseObject
    {
        public Phong_ThietBis(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        int soLuong;
        ThietBi thietBi;
        Phong phong;

        public Phong Phong
        {
            get => phong;
            set => SetPropertyValue(nameof(Phong), ref phong, value);
        }

        public ThietBi ThietBi
        {
            get => thietBi;
            set => SetPropertyValue(nameof(ThietBi), ref thietBi, value);
        }

        public int SoLuong
        {
            get => soLuong;
            set => SetPropertyValue(nameof(SoLuong), ref soLuong, value);
        }
    }
}
