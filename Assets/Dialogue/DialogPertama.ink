->main
===main===
.
Kamu mau kemana ?
    +[-Jelajah-]
        ->A
    +[-Mencari Seseorang-]
        ->B
    +[-Marah-]
        ->C
->END

===A===
Mana izinnya !?
    +[-Kasih izin-]
        ->D 
    +[-Beralasan-]
        ->E
    +[-Kabur-]
        ->F 
->END

===B===
YOU : Saya ingin mencari seseorang
Apkah kamu punya izin nya ?
->A

===C===
YOU : Jangan campuri urusan saya !!
Konsekuensi untuk berpergian tanpa izin adalah nyawa !!
->END

===D===
YOU : ini izinnya
Baiklah, silahkan !!
->END

===E===
you : saya diutus oleh sang raja untuk berkelana, ini bukti surat nyawa
(Menyodorkan surat palsu)
Baiklah, silahkan !!
->END

===F===
(Kamu langsung melarikan diri)
Konsekuensi untuk berpergian tanpa izin adalah nyawa !!
->END
