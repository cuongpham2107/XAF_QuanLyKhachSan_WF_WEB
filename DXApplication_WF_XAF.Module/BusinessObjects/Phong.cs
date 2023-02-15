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
    [DefaultProperty(nameof(TenPhong))]
    [ImageName("")]
    [XafDisplayName("Phòng")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    public class Phong : BaseObject
    {
        public Phong(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        DatPhong datPhong;
        LoaiPhong loaiPhong;
        Tang tang;
        bool trangThai;
        string tenPhong;
        [XafDisplayName("Tên phòng")]
        public string TenPhong
        {
            get => tenPhong;
            set => SetPropertyValue(nameof(TenPhong), ref tenPhong, value);
        }
        [XafDisplayName("Trạng thái")]
        public bool TrangThai
        {
            get => trangThai;
            set => SetPropertyValue(nameof(TrangThai), ref trangThai, value);
        }
        [XafDisplayName("Tầng")]
        public Tang Tang
        {
            get => tang;
            set => SetPropertyValue(nameof(Tang), ref tang, value);
        }
        [XafDisplayName("Loại phòng")]
        public LoaiPhong LoaiPhong
        {
            get => loaiPhong;
            set => SetPropertyValue(nameof(LoaiPhong), ref loaiPhong, value);
        }
        [Association("DatPhong-Phongs")]
        [VisibleInDetailView(true)]
        [VisibleInListView(true)]
        [XafDisplayName("Đặt phòng")]
        public DatPhong DatPhong
        {
            get => datPhong;
            set => SetPropertyValue(nameof(DatPhong), ref datPhong, value);
        }
    }
}