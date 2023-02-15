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
    [DefaultProperty(nameof(TenThietBi))]
    [ImageName("")]
    [XafDisplayName("Thiết bị")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    public class ThietBi : BaseObject
    {
        public ThietBi(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        float donGia;
        string tenThietBi;
        [XafDisplayName("Tên thiết bị")]
        public string TenThietBi
        {
            get => tenThietBi;
            set => SetPropertyValue(nameof(TenThietBi), ref tenThietBi, value);
        }
        [XafDisplayName("Đơn giá")]
        public float DonGia
        {
            get => donGia;
            set => SetPropertyValue(nameof(DonGia), ref donGia, value);
        }
    }
}