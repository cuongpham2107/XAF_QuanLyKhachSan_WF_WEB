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
    [DefaultProperty(nameof(TenLoaiPhong))]
    [ImageName("")]
    [XafDisplayName("Loại phòng")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    public class LoaiPhong : BaseObject
    {
        public LoaiPhong(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        int soGiuong;
        int soNguoi;
        string donGia;
        string tenLoaiPhong;
        [XafDisplayName("Tên loại phòng")]
        public string TenLoaiPhong
        {
            get => tenLoaiPhong;
            set => SetPropertyValue(nameof(TenLoaiPhong), ref tenLoaiPhong, value);
        }
        [XafDisplayName("Đơn giá")]
        public string DonGia
        {
            get => donGia;
            set => SetPropertyValue(nameof(DonGia), ref donGia, value);
        }
        [XafDisplayName("Số người")]
        public int SoNguoi
        {
            get => soNguoi;
            set => SetPropertyValue(nameof(SoNguoi), ref soNguoi, value);
        }
        [XafDisplayName("Số giường")]
        public int SoGiuong
        {
            get => soGiuong;
            set => SetPropertyValue(nameof(SoGiuong), ref soGiuong, value);
        }
    }
}