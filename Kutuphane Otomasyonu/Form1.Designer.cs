
namespace Kutuphane_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabKitaplar = new System.Windows.Forms.TabPage();
            this.btnAlinanKitapKaydet = new System.Windows.Forms.Button();
            this.lblAlinanUyeNo = new System.Windows.Forms.Label();
            this.txtAlinanUyeNo = new System.Windows.Forms.TextBox();
            this.lblAlinanKitap = new System.Windows.Forms.Label();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.lblEklenenKitapAdi = new System.Windows.Forms.Label();
            this.txtEklenenKitapAdi = new System.Windows.Forms.TextBox();
            this.lblKitapEkle = new System.Windows.Forms.Label();
            this.btnKitabiVer = new System.Windows.Forms.Button();
            this.mTxtVerilisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lblUyeAdi = new System.Windows.Forms.Label();
            this.txtUyeAdi = new System.Windows.Forms.TextBox();
            this.lblVerilisTarihi = new System.Windows.Forms.Label();
            this.lblUyeNo = new System.Windows.Forms.Label();
            this.txtUyeNo = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.lblKitapTeslim = new System.Windows.Forms.Label();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.lblKitapListesi = new System.Windows.Forms.Label();
            this.dgwKitaplar = new System.Windows.Forms.DataGridView();
            this.tabUyeler = new System.Windows.Forms.TabPage();
            this.btnUyeKayit = new System.Windows.Forms.Button();
            this.lblUyeKayitAdi = new System.Windows.Forms.Label();
            this.txtUyeKayitAdi = new System.Windows.Forms.TextBox();
            this.lblUyeEkle = new System.Windows.Forms.Label();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.lblUyeListesi = new System.Windows.Forms.Label();
            this.dgwUyeler = new System.Windows.Forms.DataGridView();
            this.lblKitapNo = new System.Windows.Forms.Label();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.txtAlinanKitapNo = new System.Windows.Forms.TextBox();
            this.lblAlinanKitapNo = new System.Windows.Forms.Label();
            this.lblKitapRafNo = new System.Windows.Forms.Label();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.lblKitaplikNo = new System.Windows.Forms.Label();
            this.txtKitaplikNo = new System.Windows.Forms.TextBox();
            this.btnOduncKitapListele = new System.Windows.Forms.Button();
            this.lblOduncKitaplar = new System.Windows.Forms.Label();
            this.dgvOduncKitapListesi = new System.Windows.Forms.DataGridView();
            this.tabMenu.SuspendLayout();
            this.tabKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).BeginInit();
            this.tabUyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitapListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabKitaplar);
            this.tabMenu.Controls.Add(this.tabUyeler);
            this.tabMenu.Location = new System.Drawing.Point(0, 3);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1517, 536);
            this.tabMenu.TabIndex = 0;
            // 
            // tabKitaplar
            // 
            this.tabKitaplar.Controls.Add(this.btnOduncKitapListele);
            this.tabKitaplar.Controls.Add(this.lblOduncKitaplar);
            this.tabKitaplar.Controls.Add(this.dgvOduncKitapListesi);
            this.tabKitaplar.Controls.Add(this.lblKitaplikNo);
            this.tabKitaplar.Controls.Add(this.txtKitaplikNo);
            this.tabKitaplar.Controls.Add(this.lblKitapRafNo);
            this.tabKitaplar.Controls.Add(this.txtRafNo);
            this.tabKitaplar.Controls.Add(this.btnAlinanKitapKaydet);
            this.tabKitaplar.Controls.Add(this.lblAlinanUyeNo);
            this.tabKitaplar.Controls.Add(this.txtAlinanUyeNo);
            this.tabKitaplar.Controls.Add(this.lblAlinanKitapNo);
            this.tabKitaplar.Controls.Add(this.lblAlinanKitap);
            this.tabKitaplar.Controls.Add(this.txtAlinanKitapNo);
            this.tabKitaplar.Controls.Add(this.btnKitapEkle);
            this.tabKitaplar.Controls.Add(this.lblEklenenKitapAdi);
            this.tabKitaplar.Controls.Add(this.txtEklenenKitapAdi);
            this.tabKitaplar.Controls.Add(this.lblKitapEkle);
            this.tabKitaplar.Controls.Add(this.btnKitabiVer);
            this.tabKitaplar.Controls.Add(this.mTxtVerilisTarihi);
            this.tabKitaplar.Controls.Add(this.lblUyeAdi);
            this.tabKitaplar.Controls.Add(this.txtUyeAdi);
            this.tabKitaplar.Controls.Add(this.lblVerilisTarihi);
            this.tabKitaplar.Controls.Add(this.lblUyeNo);
            this.tabKitaplar.Controls.Add(this.txtUyeNo);
            this.tabKitaplar.Controls.Add(this.lblKitapAdi);
            this.tabKitaplar.Controls.Add(this.txtKitapAdi);
            this.tabKitaplar.Controls.Add(this.lblKitapNo);
            this.tabKitaplar.Controls.Add(this.lblKitapTeslim);
            this.tabKitaplar.Controls.Add(this.txtKitapNo);
            this.tabKitaplar.Controls.Add(this.btnKitapListele);
            this.tabKitaplar.Controls.Add(this.lblKitapListesi);
            this.tabKitaplar.Controls.Add(this.dgwKitaplar);
            this.tabKitaplar.Location = new System.Drawing.Point(4, 25);
            this.tabKitaplar.Name = "tabKitaplar";
            this.tabKitaplar.Padding = new System.Windows.Forms.Padding(3);
            this.tabKitaplar.Size = new System.Drawing.Size(1509, 507);
            this.tabKitaplar.TabIndex = 2;
            this.tabKitaplar.Text = "Kitaplar";
            this.tabKitaplar.UseVisualStyleBackColor = true;
            // 
            // btnAlinanKitapKaydet
            // 
            this.btnAlinanKitapKaydet.Location = new System.Drawing.Point(660, 353);
            this.btnAlinanKitapKaydet.Name = "btnAlinanKitapKaydet";
            this.btnAlinanKitapKaydet.Size = new System.Drawing.Size(125, 23);
            this.btnAlinanKitapKaydet.TabIndex = 28;
            this.btnAlinanKitapKaydet.Text = "Kaydet";
            this.btnAlinanKitapKaydet.UseVisualStyleBackColor = true;
            this.btnAlinanKitapKaydet.Click += new System.EventHandler(this.btnAlinanKitapKaydet_Click);
            // 
            // lblAlinanUyeNo
            // 
            this.lblAlinanUyeNo.AutoSize = true;
            this.lblAlinanUyeNo.Location = new System.Drawing.Point(666, 317);
            this.lblAlinanUyeNo.Name = "lblAlinanUyeNo";
            this.lblAlinanUyeNo.Size = new System.Drawing.Size(55, 17);
            this.lblAlinanUyeNo.TabIndex = 27;
            this.lblAlinanUyeNo.Text = "Üye No";
            // 
            // txtAlinanUyeNo
            // 
            this.txtAlinanUyeNo.Location = new System.Drawing.Point(755, 314);
            this.txtAlinanUyeNo.Name = "txtAlinanUyeNo";
            this.txtAlinanUyeNo.Size = new System.Drawing.Size(146, 22);
            this.txtAlinanUyeNo.TabIndex = 26;
            // 
            // lblAlinanKitap
            // 
            this.lblAlinanKitap.AutoSize = true;
            this.lblAlinanKitap.Location = new System.Drawing.Point(666, 226);
            this.lblAlinanKitap.Name = "lblAlinanKitap";
            this.lblAlinanKitap.Size = new System.Drawing.Size(100, 17);
            this.lblAlinanKitap.TabIndex = 24;
            this.lblAlinanKitap.Text = "ALINAN KİTAP";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(349, 401);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(125, 23);
            this.btnKitapEkle.TabIndex = 22;
            this.btnKitapEkle.Text = "Kaydet";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // lblEklenenKitapAdi
            // 
            this.lblEklenenKitapAdi.AutoSize = true;
            this.lblEklenenKitapAdi.Location = new System.Drawing.Point(344, 271);
            this.lblEklenenKitapAdi.Name = "lblEklenenKitapAdi";
            this.lblEklenenKitapAdi.Size = new System.Drawing.Size(64, 17);
            this.lblEklenenKitapAdi.TabIndex = 21;
            this.lblEklenenKitapAdi.Text = "Kitap Adı";
            // 
            // txtEklenenKitapAdi
            // 
            this.txtEklenenKitapAdi.Location = new System.Drawing.Point(433, 268);
            this.txtEklenenKitapAdi.Name = "txtEklenenKitapAdi";
            this.txtEklenenKitapAdi.Size = new System.Drawing.Size(146, 22);
            this.txtEklenenKitapAdi.TabIndex = 20;
            // 
            // lblKitapEkle
            // 
            this.lblKitapEkle.AutoSize = true;
            this.lblKitapEkle.Location = new System.Drawing.Point(346, 226);
            this.lblKitapEkle.Name = "lblKitapEkle";
            this.lblKitapEkle.Size = new System.Drawing.Size(86, 17);
            this.lblKitapEkle.TabIndex = 18;
            this.lblKitapEkle.Text = "KİTAP EKLE";
            // 
            // btnKitabiVer
            // 
            this.btnKitabiVer.Location = new System.Drawing.Point(6, 478);
            this.btnKitabiVer.Name = "btnKitabiVer";
            this.btnKitabiVer.Size = new System.Drawing.Size(125, 23);
            this.btnKitabiVer.TabIndex = 16;
            this.btnKitabiVer.Text = "Kaydet";
            this.btnKitabiVer.UseVisualStyleBackColor = true;
            this.btnKitabiVer.Click += new System.EventHandler(this.btnKitabiVer_Click);
            // 
            // mTxtVerilisTarihi
            // 
            this.mTxtVerilisTarihi.Location = new System.Drawing.Point(100, 440);
            this.mTxtVerilisTarihi.Mask = "00/00/0000";
            this.mTxtVerilisTarihi.Name = "mTxtVerilisTarihi";
            this.mTxtVerilisTarihi.Size = new System.Drawing.Size(143, 22);
            this.mTxtVerilisTarihi.TabIndex = 15;
            this.mTxtVerilisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lblUyeAdi
            // 
            this.lblUyeAdi.AutoSize = true;
            this.lblUyeAdi.Location = new System.Drawing.Point(8, 401);
            this.lblUyeAdi.Name = "lblUyeAdi";
            this.lblUyeAdi.Size = new System.Drawing.Size(61, 17);
            this.lblUyeAdi.TabIndex = 14;
            this.lblUyeAdi.Text = "Üye İsmi";
            // 
            // txtUyeAdi
            // 
            this.txtUyeAdi.Location = new System.Drawing.Point(97, 398);
            this.txtUyeAdi.Name = "txtUyeAdi";
            this.txtUyeAdi.Size = new System.Drawing.Size(146, 22);
            this.txtUyeAdi.TabIndex = 13;
            // 
            // lblVerilisTarihi
            // 
            this.lblVerilisTarihi.AutoSize = true;
            this.lblVerilisTarihi.Location = new System.Drawing.Point(8, 445);
            this.lblVerilisTarihi.Name = "lblVerilisTarihi";
            this.lblVerilisTarihi.Size = new System.Drawing.Size(86, 17);
            this.lblVerilisTarihi.TabIndex = 12;
            this.lblVerilisTarihi.Text = "Veriliş Tarihi";
            // 
            // lblUyeNo
            // 
            this.lblUyeNo.AutoSize = true;
            this.lblUyeNo.Location = new System.Drawing.Point(8, 359);
            this.lblUyeNo.Name = "lblUyeNo";
            this.lblUyeNo.Size = new System.Drawing.Size(55, 17);
            this.lblUyeNo.TabIndex = 10;
            this.lblUyeNo.Text = "Üye No";
            // 
            // txtUyeNo
            // 
            this.txtUyeNo.Location = new System.Drawing.Point(97, 356);
            this.txtUyeNo.Name = "txtUyeNo";
            this.txtUyeNo.Size = new System.Drawing.Size(146, 22);
            this.txtUyeNo.TabIndex = 9;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(8, 314);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(64, 17);
            this.lblKitapAdi.TabIndex = 8;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(97, 311);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(146, 22);
            this.txtKitapAdi.TabIndex = 7;
            // 
            // lblKitapTeslim
            // 
            this.lblKitapTeslim.AutoSize = true;
            this.lblKitapTeslim.Location = new System.Drawing.Point(8, 226);
            this.lblKitapTeslim.Name = "lblKitapTeslim";
            this.lblKitapTeslim.Size = new System.Drawing.Size(109, 17);
            this.lblKitapTeslim.TabIndex = 5;
            this.lblKitapTeslim.Text = "VERİLEN KİTAP";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(10, 18);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(75, 23);
            this.btnKitapListele.TabIndex = 3;
            this.btnKitapListele.Text = "Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // lblKitapListesi
            // 
            this.lblKitapListesi.AutoSize = true;
            this.lblKitapListesi.Location = new System.Drawing.Point(7, 55);
            this.lblKitapListesi.Name = "lblKitapListesi";
            this.lblKitapListesi.Size = new System.Drawing.Size(84, 17);
            this.lblKitapListesi.TabIndex = 2;
            this.lblKitapListesi.Text = "Kitap Listesi";
            // 
            // dgwKitaplar
            // 
            this.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitaplar.Location = new System.Drawing.Point(97, 15);
            this.dgwKitaplar.Name = "dgwKitaplar";
            this.dgwKitaplar.RowHeadersWidth = 51;
            this.dgwKitaplar.RowTemplate.Height = 24;
            this.dgwKitaplar.Size = new System.Drawing.Size(652, 195);
            this.dgwKitaplar.TabIndex = 1;
            // 
            // tabUyeler
            // 
            this.tabUyeler.Controls.Add(this.btnUyeKayit);
            this.tabUyeler.Controls.Add(this.lblUyeKayitAdi);
            this.tabUyeler.Controls.Add(this.txtUyeKayitAdi);
            this.tabUyeler.Controls.Add(this.lblUyeEkle);
            this.tabUyeler.Controls.Add(this.btnUyeListele);
            this.tabUyeler.Controls.Add(this.lblUyeListesi);
            this.tabUyeler.Controls.Add(this.dgwUyeler);
            this.tabUyeler.Location = new System.Drawing.Point(4, 25);
            this.tabUyeler.Name = "tabUyeler";
            this.tabUyeler.Size = new System.Drawing.Size(999, 507);
            this.tabUyeler.TabIndex = 3;
            this.tabUyeler.Text = "Üyeler";
            this.tabUyeler.UseVisualStyleBackColor = true;
            // 
            // btnUyeKayit
            // 
            this.btnUyeKayit.Location = new System.Drawing.Point(12, 381);
            this.btnUyeKayit.Name = "btnUyeKayit";
            this.btnUyeKayit.Size = new System.Drawing.Size(125, 23);
            this.btnUyeKayit.TabIndex = 26;
            this.btnUyeKayit.Text = "Kaydet";
            this.btnUyeKayit.UseVisualStyleBackColor = true;
            this.btnUyeKayit.Click += new System.EventHandler(this.btnUyeKayit_Click);
            // 
            // lblUyeKayitAdi
            // 
            this.lblUyeKayitAdi.AutoSize = true;
            this.lblUyeKayitAdi.Location = new System.Drawing.Point(9, 342);
            this.lblUyeKayitAdi.Name = "lblUyeKayitAdi";
            this.lblUyeKayitAdi.Size = new System.Drawing.Size(57, 17);
            this.lblUyeKayitAdi.TabIndex = 25;
            this.lblUyeKayitAdi.Text = "Üye Adı";
            // 
            // txtUyeKayitAdi
            // 
            this.txtUyeKayitAdi.Location = new System.Drawing.Point(98, 339);
            this.txtUyeKayitAdi.Name = "txtUyeKayitAdi";
            this.txtUyeKayitAdi.Size = new System.Drawing.Size(146, 22);
            this.txtUyeKayitAdi.TabIndex = 24;
            // 
            // lblUyeEkle
            // 
            this.lblUyeEkle.AutoSize = true;
            this.lblUyeEkle.Location = new System.Drawing.Point(8, 301);
            this.lblUyeEkle.Name = "lblUyeEkle";
            this.lblUyeEkle.Size = new System.Drawing.Size(75, 17);
            this.lblUyeEkle.TabIndex = 23;
            this.lblUyeEkle.Text = "ÜYE EKLE";
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Location = new System.Drawing.Point(16, 16);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(75, 23);
            this.btnUyeListele.TabIndex = 6;
            this.btnUyeListele.Text = "Listele";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // lblUyeListesi
            // 
            this.lblUyeListesi.AutoSize = true;
            this.lblUyeListesi.Location = new System.Drawing.Point(13, 53);
            this.lblUyeListesi.Name = "lblUyeListesi";
            this.lblUyeListesi.Size = new System.Drawing.Size(77, 17);
            this.lblUyeListesi.TabIndex = 5;
            this.lblUyeListesi.Text = "Üye Listesi";
            // 
            // dgwUyeler
            // 
            this.dgwUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUyeler.Location = new System.Drawing.Point(103, 13);
            this.dgwUyeler.Name = "dgwUyeler";
            this.dgwUyeler.RowHeadersWidth = 51;
            this.dgwUyeler.RowTemplate.Height = 24;
            this.dgwUyeler.Size = new System.Drawing.Size(441, 195);
            this.dgwUyeler.TabIndex = 4;
            // 
            // lblKitapNo
            // 
            this.lblKitapNo.AutoSize = true;
            this.lblKitapNo.Location = new System.Drawing.Point(8, 273);
            this.lblKitapNo.Name = "lblKitapNo";
            this.lblKitapNo.Size = new System.Drawing.Size(62, 17);
            this.lblKitapNo.TabIndex = 6;
            this.lblKitapNo.Text = "Kitap No";
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Location = new System.Drawing.Point(97, 270);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(146, 22);
            this.txtKitapNo.TabIndex = 4;
            // 
            // txtAlinanKitapNo
            // 
            this.txtAlinanKitapNo.Location = new System.Drawing.Point(755, 270);
            this.txtAlinanKitapNo.Name = "txtAlinanKitapNo";
            this.txtAlinanKitapNo.Size = new System.Drawing.Size(146, 22);
            this.txtAlinanKitapNo.TabIndex = 23;
            // 
            // lblAlinanKitapNo
            // 
            this.lblAlinanKitapNo.AutoSize = true;
            this.lblAlinanKitapNo.Location = new System.Drawing.Point(666, 273);
            this.lblAlinanKitapNo.Name = "lblAlinanKitapNo";
            this.lblAlinanKitapNo.Size = new System.Drawing.Size(62, 17);
            this.lblAlinanKitapNo.TabIndex = 25;
            this.lblAlinanKitapNo.Text = "Kitap No";
            // 
            // lblKitapRafNo
            // 
            this.lblKitapRafNo.AutoSize = true;
            this.lblKitapRafNo.Location = new System.Drawing.Point(344, 362);
            this.lblKitapRafNo.Name = "lblKitapRafNo";
            this.lblKitapRafNo.Size = new System.Drawing.Size(52, 17);
            this.lblKitapRafNo.TabIndex = 30;
            this.lblKitapRafNo.Text = "Raf No";
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(433, 359);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(146, 22);
            this.txtRafNo.TabIndex = 29;
            // 
            // lblKitaplikNo
            // 
            this.lblKitaplikNo.AutoSize = true;
            this.lblKitaplikNo.Location = new System.Drawing.Point(344, 314);
            this.lblKitaplikNo.Name = "lblKitaplikNo";
            this.lblKitaplikNo.Size = new System.Drawing.Size(72, 17);
            this.lblKitaplikNo.TabIndex = 32;
            this.lblKitaplikNo.Text = "Kitapık No";
            // 
            // txtKitaplikNo
            // 
            this.txtKitaplikNo.Location = new System.Drawing.Point(433, 311);
            this.txtKitaplikNo.Name = "txtKitaplikNo";
            this.txtKitaplikNo.Size = new System.Drawing.Size(146, 22);
            this.txtKitaplikNo.TabIndex = 31;
            // 
            // btnOduncKitapListele
            // 
            this.btnOduncKitapListele.Location = new System.Drawing.Point(812, 18);
            this.btnOduncKitapListele.Name = "btnOduncKitapListele";
            this.btnOduncKitapListele.Size = new System.Drawing.Size(75, 23);
            this.btnOduncKitapListele.TabIndex = 35;
            this.btnOduncKitapListele.Text = "Listele";
            this.btnOduncKitapListele.UseVisualStyleBackColor = true;
            this.btnOduncKitapListele.Click += new System.EventHandler(this.btnOduncKitapListele_Click);
            // 
            // lblOduncKitaplar
            // 
            this.lblOduncKitaplar.AutoSize = true;
            this.lblOduncKitaplar.Location = new System.Drawing.Point(757, 58);
            this.lblOduncKitaplar.Name = "lblOduncKitaplar";
            this.lblOduncKitaplar.Size = new System.Drawing.Size(130, 17);
            this.lblOduncKitaplar.TabIndex = 34;
            this.lblOduncKitaplar.Text = "Ödünç Kitap Listesi";
            // 
            // dgvOduncKitapListesi
            // 
            this.dgvOduncKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncKitapListesi.Location = new System.Drawing.Point(902, 15);
            this.dgvOduncKitapListesi.Name = "dgvOduncKitapListesi";
            this.dgvOduncKitapListesi.RowHeadersWidth = 51;
            this.dgvOduncKitapListesi.RowTemplate.Height = 24;
            this.dgvOduncKitapListesi.Size = new System.Drawing.Size(577, 195);
            this.dgvOduncKitapListesi.TabIndex = 33;
            this.dgvOduncKitapListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 551);
            this.Controls.Add(this.tabMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMenu.ResumeLayout(false);
            this.tabKitaplar.ResumeLayout(false);
            this.tabKitaplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).EndInit();
            this.tabUyeler.ResumeLayout(false);
            this.tabUyeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncKitapListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabKitaplar;
        private System.Windows.Forms.TabPage tabUyeler;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Label lblKitapListesi;
        private System.Windows.Forms.DataGridView dgwKitaplar;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblKitapTeslim;
        private System.Windows.Forms.Label lblVerilisTarihi;
        private System.Windows.Forms.Label lblUyeNo;
        private System.Windows.Forms.TextBox txtUyeNo;
        private System.Windows.Forms.Button btnAlinanKitapKaydet;
        private System.Windows.Forms.Label lblAlinanUyeNo;
        private System.Windows.Forms.TextBox txtAlinanUyeNo;
        private System.Windows.Forms.Label lblAlinanKitap;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label lblEklenenKitapAdi;
        private System.Windows.Forms.TextBox txtEklenenKitapAdi;
        private System.Windows.Forms.Label lblKitapEkle;
        private System.Windows.Forms.Button btnKitabiVer;
        private System.Windows.Forms.MaskedTextBox mTxtVerilisTarihi;
        private System.Windows.Forms.Label lblUyeAdi;
        private System.Windows.Forms.TextBox txtUyeAdi;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Label lblUyeListesi;
        private System.Windows.Forms.DataGridView dgwUyeler;
        private System.Windows.Forms.Button btnUyeKayit;
        private System.Windows.Forms.Label lblUyeKayitAdi;
        private System.Windows.Forms.TextBox txtUyeKayitAdi;
        private System.Windows.Forms.Label lblUyeEkle;
        private System.Windows.Forms.Label lblKitaplikNo;
        private System.Windows.Forms.TextBox txtKitaplikNo;
        private System.Windows.Forms.Label lblKitapRafNo;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.Label lblAlinanKitapNo;
        private System.Windows.Forms.TextBox txtAlinanKitapNo;
        private System.Windows.Forms.Label lblKitapNo;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.Button btnOduncKitapListele;
        private System.Windows.Forms.Label lblOduncKitaplar;
        private System.Windows.Forms.DataGridView dgvOduncKitapListesi;
    }
}

