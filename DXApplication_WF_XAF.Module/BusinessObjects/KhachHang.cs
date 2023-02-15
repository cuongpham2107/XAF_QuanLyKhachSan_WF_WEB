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
    [DefaultProperty(nameof(HoTen))]
    [ImageName("")]
    [XafDisplayName("Khách hàng")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    public class KhachHang : BaseObject
    {
        public KhachHang(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        bool trangThai;
        string diaChi;
        string email;
        string soCMND;
        bool gioiTinh;
        string dienThoai;
        string hoTen;
        [XafDisplayName("Họ và tên")]
        public string HoTen
        {
            get => hoTen;
            set => SetPropertyValue(nameof(HoTen), ref hoTen, value);
        }
        [XafDisplayName("Số điện thoại")]
        public string DienThoai
        {
            get => dienThoai;
            set => SetPropertyValue(nameof(DienThoai), ref dienThoai, value);
        }
        [XafDisplayName("Giới tính")]
        public bool GioiTinh
        {
            get => gioiTinh;
            set => SetPropertyValue(nameof(GioiTinh), ref gioiTinh, value);
        }
        [XafDisplayName("Số CMND")]
        public string SoCMND
        {
            get => soCMND;
            set => SetPropertyValue(nameof(SoCMND), ref soCMND, value);
        }
        [XafDisplayName("Email")]
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
        [XafDisplayName("Trạng thái")]
        public bool TrangThai
        {
            get => trangThai;
            set => SetPropertyValue(nameof(TrangThai), ref trangThai, value);
        }
    }

}