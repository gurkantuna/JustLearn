namespace Pattern.Domain.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    public partial class Category {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category() {
            Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        //For old images for Notrhwind db
        public string Base64String {
            get {
                if (this.Picture == null) {
                    return string.Empty;
                }
                var base64Str = string.Empty;
                using (var ms = new MemoryStream()) {
                    int offset = 78;
                    ms.Write(Picture, offset, Picture.Length - offset);
                    var bmp = new Bitmap(ms);
                    using (var jpegms = new MemoryStream()) {
                        bmp.Save(jpegms, ImageFormat.Jpeg);
                        base64Str = Convert.ToBase64String(jpegms.ToArray());
                    }
                }
                return base64Str;
            }
        }

    }
}
