->main

===main===

RRRRRRR.. Bark ! bark ! bark !
    +[-Pet-]
        ->a 
    +[-Panik-]
        ->b 
    +[-Kabur-]
        ->c
->END

===a===
(Serigala tersebut menggigit)
->d

===b===
Waduh bagaimana ini ? Ada serigala besar.
->d

===c===
(Kamu meninggalkan serigala tersebut)
->END

===d===
(Serigala tersebut berbicara)
Mau apa kamu di sini !?
    +[-Alasan Berpergian-]
        ->e
    +[-Alasan menjelajahi-]
        ->e
    +[-Mencoba menenangkan-]
        ->e
->END

===e===
Pergi sana !! Jangan datang ke wilayah ku lagi !!
->END