using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DXApplication_WF_XAF.Module.Common;
using System;
using System.ComponentModel;
using System.Linq;
using static DXApplication_WF_XAF.Module.Common.Enums;

namespace DXApplication_WF_XAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem(Menu.MenuHotels)]
    [DefaultProperty(nameof(PhieuDatPhong))]
    [ImageName("")]
    [XafDisplayName("Đặt phòng")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]

    public class DatPhong : BaseObject
    {
        public DatPhong(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        #region Properties
        string phieuDatPhong;
        string ghiChu;
        bool khachDoan;
        TrangThaiDatPhong trangThai;
        DonVi donVi;
        ApplicationUser applicationUser;
        int soNgay;
        DateTime? ngayTra;
        DateTime? ngayDat;
        KhachHang khachHang;
        [XafDisplayName("Phiếu đặt phòng")]
        public string PhieuDatPhong
        {
            get
            {
                return phieuDatPhong;
            }
            set => SetPropertyValue(nameof(PhieuDatPhong), ref phieuDatPhong, value);
        }
        [XafDisplayName("Khách hàng")]
        public KhachHang KhachHang
        {
            get => khachHang;
            set => SetPropertyValue(nameof(KhachHang), ref khachHang, value);
        }
        [XafDisplayName("Ngày đặt")]
        public DateTime? NgayDat
        {
            get => ngayDat;
            set => SetPropertyValue(nameof(NgayDat), ref ngayDat, value);
        }
        [XafDisplayName("Ngày trả")]
        public DateTime? NgayTra
        {
            get => ngayTra;
            set => SetPropertyValue(nameof(NgayTra), ref ngayTra, value);
        }
        [XafDisplayName("Số ngày ở")]
        [ModelDefault("AllowEdit", "False")]
        public int SoNgay
        {
            get
            {
                if (NgayDat != null && NgayTra != null)
                {
                    TimeSpan time = (TimeSpan)(NgayTra - NgayDat);
                    int TongSoNgay = time.Days;

                    return TongSoNgay;
                }
                return soNgay;
            }
            set => SetPropertyValue(nameof(SoNgay), ref soNgay, value);
        }
        [XafDisplayName("Người đặt")]
        public ApplicationUser ApplicationUser
        {
            get => applicationUser;
            set => SetPropertyValue(nameof(ApplicationUser), ref applicationUser, value);
        }
        [XafDisplayName("Đơn vị")]
        public DonVi DonVi
        {
            get => donVi;
            set => SetPropertyValue(nameof(DonVi), ref donVi, value);
        }
        [XafDisplayName("Trạng thái")]
        public TrangThaiDatPhong TrangThai
        {
            get => trangThai;
            set => SetPropertyValue(nameof(TrangThai), ref trangThai, value);
        }
        [PersistentAlias("")]
        [XafDisplayName("Khách đoàn")]
        [CaptionsForBoolValues("Có", "Không")]
        public bool KhachDoan
        {
            get => khachDoan;
            set => SetPropertyValue(nameof(KhachDoan), ref khachDoan, value);
        }
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }
        #endregion

        #region Association
        [XafDisplayName("Danh sách phòng đặt")]
        [Association("DatPhong-Phongs")]
        public XPCollection<Phong> Phongs
        {
            get
            {
                return GetCollection<Phong>(nameof(Phongs));
            }
        }
        [XafDisplayName("Dịch vụ")]
        [Association("DatPhong-DatPhong_DichVuss")]
        public XPCollection<DatPhong_DichVus> DatPhong_DichVuss
        {
            get
            {
                return GetCollection<DatPhong_DichVus>(nameof(DatPhong_DichVuss));
            }
        }
        #endregion

    }
}