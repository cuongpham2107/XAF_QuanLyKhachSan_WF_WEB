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
    [NavigationItem(Menu.MenuHotels)]
    [DefaultProperty(nameof(TenDichVu))]
    [ImageName("")]
    [XafDisplayName("Dịch vụ")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    public class DichVu : BaseObject
    {
        public DichVu(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string donViTinh;
        float donGia;
        string tenDichVu;
        [XafDisplayName("Tên dịch vụ")]
        public string TenDichVu
        {
            get => tenDichVu;
            set => SetPropertyValue(nameof(TenDichVu), ref tenDichVu, value);
        }
        [XafDisplayName("Đơn giá")]
        public float DonGia
        {
            get => donGia;
            set => SetPropertyValue(nameof(DonGia), ref donGia, value);
        }
        [XafDisplayName("Đơn vị tính")]
        public string DonViTinh
        {
            get => donViTinh;
            set => SetPropertyValue(nameof(DonViTinh), ref donViTinh, value);
        }
    }
}