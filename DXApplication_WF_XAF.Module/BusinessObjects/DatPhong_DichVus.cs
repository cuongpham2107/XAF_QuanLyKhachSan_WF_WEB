using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace DXApplication_WF_XAF.Module.BusinessObjects
{
    [DefaultClassOptions]

    public class DatPhong_DichVus : BaseObject
    {
        public DatPhong_DichVus(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string donViTinh;
        float donGia;
        int soLuong;
        DichVu dichVu;
        DatPhong datPhong;
        [Association("DatPhong-DatPhong_DichVuss")]
        public DatPhong DatPhong
        {
            get => datPhong;
            set => SetPropertyValue(nameof(DatPhong), ref datPhong, value);
        }
        [XafDisplayName("Tên dịch vụ")]
        public DichVu DichVu
        {
            get => dichVu;
            set => SetPropertyValue(nameof(DichVu), ref dichVu, value);
        }
        [XafDisplayName("Đơn giá")]
        [ModelDefault("AllowEdit", "False")]
        public float DonGia
        {
            get
            {
                if (!IsLoading && !IsSaving)
                {
                    if (DichVu != null)
                    {
                        return DichVu.DonGia;
                    }
                }
                return donGia;
            }
            set => SetPropertyValue(nameof(DonGia), ref donGia, value);
        }
        [XafDisplayName("Đơn vị tính")]
        [ModelDefault("AllowEdit", "False")]
        public string DonViTinh
        {
            get
            {
                if (!IsLoading && !IsSaving)
                {
                    if (DichVu != null)
                    {
                        return DichVu.DonViTinh;
                    }
                }
                return donViTinh;
            }
            set => SetPropertyValue(nameof(DonViTinh), ref donViTinh, value);
        }
        [XafDisplayName("Số lượng")]
        public int SoLuong
        {
            get => soLuong;
            set => SetPropertyValue(nameof(SoLuong), ref soLuong, value);
        }
    }
}