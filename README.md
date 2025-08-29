# 📚 Buku App - Aplikasi Data Buku Sederhana

Aplikasi console sederhana menggunakan **C#** untuk menampilkan, mengubah, dan memperbarui data buku.  
Project ini dibuat sebagai latihan **Object Oriented Programming (OOP)** dasar.

---

## 🚀 Fitur
- Menampilkan data buku (judul, penulis, tahun, harga).
- Memperbarui data buku melalui input dari pengguna.
- Menampilkan data setelah diperbarui.

---

## 🛠️ Teknologi
- Bahasa: **C#**
- Framework: **.NET Console Application**

---

## 📂 Struktur Kode
- **Class `Buku`**
  - `Judul` (string)
  - `Penulis` (string)
  - `Tahun` (int)
  - `Harga` (int)
  - Method `TampilData()` → menampilkan data buku.
  
- **Class `Program`**
  - `Main()` → program utama untuk menampilkan dan memperbarui data buku.

---

## ▶️ Cara Menjalankan
1. Clone repository ini:
   ```bash
   git clone https://github.com/codebyghiats/Buku-App-Aplikasi-Data-Buku-Sederhana.git
   ```
2. Masuk ke folder project:
   ```bash
   cd Buku-App-Aplikasi-Data-Buku-Sederhana
   ```
3. Jalankan program:
   ```bash
   dotnet run
   ```

---

## 💻 Contoh Output

```
Data Buku Awal
Judul   : Pemrograman C# Dasar
Penulis : Budi Santoso
Tahun   : 2012
Harga   : Rp 75,000

Update Data Buku
Judul baru   : Pemrograman OOP
Penulis baru : Andi Wijaya
Tahun        : 2020
Harga        : 95000

Data Buku Setelah Update
Judul   : Pemrograman OOP
Penulis : Andi Wijaya
Tahun   : 2020
Harga   : Rp 95,000
```

---

## ✨ Catatan
- Program ini masih **sederhana** (belum ada validasi input).  
- Bisa dikembangkan menjadi aplikasi dengan **list banyak buku** atau disimpan ke file/database.
