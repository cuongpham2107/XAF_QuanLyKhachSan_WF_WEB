using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DXApplication_WF_XAF.Module.Common;
using System;
using System.ComponentModel;
using System.Linq;

namespace DXApplication_WF_XAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem(Menu.MenuCatalog)]
    [DefaultProperty(nameof(TenDonVi))]
    [ImageName("")]
    [XafDisplayName("Đơn vị")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]

    public class DonVi : BaseObject
    {
        public DonVi(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        CongTy congty;
        string diaChi;
        string email;
        string fax;
        string dienThoai;
        string tenDonVi;
        [XafDisplayName("Công ty")]
        public CongTy Congty
        {
            get => congty;
            set => SetPropertyValue(nameof(Congty), ref congty, value);
        }
        [XafDisplayName("Tên đơn vị")]
        public string TenDonVi
        {
            get => tenDonVi;
            set => SetPropertyValue(nameof(TenDonVi), ref tenDonVi, value);
        }
        [XafDisplayName("Số điện thoại")]
        public string DienThoai
        {
            get => dienThoai;
            set => SetPropertyValue(nameof(DienThoai), ref dienThoai, value);
        }
        [XafDisplayName("FAX")]
        public string Fax
        {
            get => fax;
            set => SetPropertyValue(nameof(Fax), ref fax, value);
        }
        [XafDisplayName("Địa chỉ email")]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }
        [XafDisplayName("Địa chỉ")]
        public string DiaChi
        {
            get => diaChi;
            set => SetPropertyValue(nameof(DiaChi), ref diaChi, value);
        }

    }
}