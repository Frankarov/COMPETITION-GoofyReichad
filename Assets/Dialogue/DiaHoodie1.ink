->main
===main===
Apa yang sedang kamu cari nak?
    +[-Insult-]
        ->insult
    +[-Silence-]
        ->silence
    +[-Ask-]
        ->Ask
->END

===insult===
YOU : Kau terlihat menyeramkan..
Dasar tidak tau sopan santun !!
->END

===silence===
You : ...
...
Kamu sedang mencari seseorang ya ?
->Ask

===Ask===
You : Saya sedang mencari seorang perempuan.
Apa ciri-ciri perempuan yang kamu cari tersebut ?
    +[Rambut biru]
        ->d1
    +[Berparas Cantik]
        ->e1
    +[Berjubah donker]
        ->f1
        
===d1===
Sepertinya saya pernah melihat perempuan tersebut..
Cobalah kamu cari dia di Negeri awan
->END
===e1===
Sepertinya saya pernah melihat perempuan tersebut..
Cobalah kamu cari dia di Negeri awan
->END
===f1===
Sepertinya saya pernah melihat perempuan tersebut..
Cobalah kamu cari dia di Negeri awan
->END
...
->END

