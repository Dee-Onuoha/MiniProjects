using System;
using static System.Console;

namespace StatesZones
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeStateZone();
        }



        static string nigerianZones = @"
1. North Central             2. North East             3. North West

4. South East             5. South South             6. South West";

        static string[] stateInZones =
        {
            "",
            @"North Central = Niger, Kogi, Benue, Plateau, Nassarawa, Kwara and the  Federal Capital Territory.",
            @"North East = Bauchi, Borno, Taraba, Adamawa, Gombe and Yobe.",
            @"North West = Zamfara, Sokoto, Kaduna, Kebbi, Katsina, Kano and Jigawa.",
            @"South East = Enugu, Imo, Ebonyi, Abia and Anambra",
            @"South South = Bayelsa, Akwa Ibom, Edo, Rivers, Cross River and Delta.",
            @"South West = Oyo, Ekiti, Osun, Ondo, Lagos and Ogun."
        };

        private static string nigerianStates = @"
1. FCT        2. Abia            3. Adamawa            4. Akwa Ibom            5.  Anambra            6. Bauchi            7. Bayelsa 
8. Benue            9. Borno            10. Cross River            11. Delta            12. Ebonyi            13. Edo
14. Ekiti            15. Enugu          16. Gombe            17. Imo            18. Jigawa            19. Kaduna            20. Kano            21. Katsina
22. Kebbi            23. Kogi            24. Kwara        25. Lagos            26. Nassarawa            27. Niger            28. Ogun            
29. Ondo            30.Osun        31. Oyo            32. Plateau            33. Rivers Port Harcourt        34. Sokoto            
35. Taraba            36. Yobe            37. Zamfara Gusau ";
        
        static string[] localGovernts = 
{
"",
@"1. Gwagwalada        2. Kuje        3. Abaji        4. Abuja Municipal        5. Bwari        6. Kwali",   
    
@"1. Aba North        2. Aba South        3. Arochukwu        4. Bende        5. Ikwuano        6. Isiala-Ngwa North 
7. Isiala-Ngwa South        8. Isuikwato        9. Obi Nwa        10. Ohafia        11. Osisioma        12. Ngwa        13.Ugwunagbo
14. Ukwa East        15. Ukwa West        16. Umuahia North        17. Umuahia South        18. Umu-Neochi",

@"1. Demsa        2. Fufore        3. Ganaye        4. Gireri        5. Gombi        6. Guyuk        7. Hong 
8. Jada        9. Lamurde        10. Madagali        11. Maiha        12. Mayo-Belwa        13. Michika        14. Mubi North 
15. Mubi South        16. Numan        17. Shelleng        18. Song        19. Toungo        20. Yola North        21. Yola South",

@"1. Abak        2. Eastern Obolo        3. Eket        4. Esit Eket        5. Essien Udim        6. Etim Ekpo        7. Etinan 
8. Ibeno        9. Ibesikpo Asutan        10. Ibiono Ibom        11. Ika        12. Ikono        13. Ikot Abasi        14. Ikot Ekpene        15. Ini 
16. Itu        17. Mbo        18. Mkpat Enin        19. Nsit Atai        20. Nsit Ibom        21. Nsit Ubium        22. Obot Akara        23. Okobo 
24. Onna        25. Oron        26. Oruk Anam        27. Udung Uko        28. Ukanafun        29. Uruan        30.Urue-Offong/Oruko        31. Uyo",

@"Aguata 
Anambra East 
Anambra West 
Anaocha 
Awka North 
Awka South 
Ayamelum 
Dunukofia 
Ekwusigo 
Idemili North 
Idemili south 
Ihiala 
Njikoka 
Nnewi North 
Nnewi South 
Ogbaru 
Onitsha North 
Onitsha South 
Orumba North 
Orumba South 
Oyi ",

@"Alkaleri 
Bauchi 
Bogoro 
Damban 
Darazo 
Dass 
Ganjuwa 
Giade 
Itas/Gadau 
Jama'are 
Katagum 
Kirfi 
Misau 
Ningi 
Shira 
Tafawa-Balewa 
Toro 
Warji 
Zaki ",

@"Brass 
Ekeremor 
Kolokuma/Opokuma 
Nembe 
Ogbia 
Sagbama 
Southern Jaw 
Yenegoa",

@"Ado 
Agatu 
Apa 
Buruku 
Gboko 
Guma 
Gwer East 
Gwer West 
Katsina-Ala 
Konshisha 
Kwande 
Logo 
Makurdi 
Obi 
Ogbadibo 
Oju 
Okpokwu 
Ohimini 
Oturkpo 
Tarka 
Ukum 
Ushongo 
Vandeikya ",

@"Abadam 
Askira/Uba 
Bama 
Bayo 
Biu 
Chibok 
Damboa 
Dikwa 
Gubio 
Guzamala 
Gwoza 
Hawul 
Jere 
Kaga 
Kala/Balge 
Konduga 
Kukawa 
Kwaya Kusar 
Mafa 
Magumeri 
Maiduguri 
Marte 
Mobbar 
Monguno 
Ngala 
Nganzai 
Shani",

@"Akpabuyo 
Odukpani 
Akamkpa 
Biase 
Abi 
Ikom 
Yarkur 
Odubra 
Boki 
Ogoja 
Yala 
Obanliku 
Obudu 
Calabar South 
Etung 
Bekwara 
Bakassi 
Calabar Municipality",

@"Oshimili 
Aniocha 
Aniocha South 
Ika South 
Ika North-East 
Ndokwa West 
Ndokwa East 
Isoko south 
Isoko North 
Bomadi 
Burutu 
Ughelli South 
Ughelli North 
Ethiope West 
Ethiope East 
Sapele 
Okpe 
Warri North 
Warri South 
Uvwie 
Udu 
Warri Central 
Ukwani 
Oshimili North 
Patani",

@"Afikpo South 
Afikpo North 
Onicha 
Ohaozara 
Abakaliki 
Ishielu 
lkwo 
Ezza 
Ezza South 
Ohaukwu 
Ebonyi 
Ivo ",

@"Esan North-East 
Esan Central 
Esan West 
Egor 
Ukpoba 
Central 
Etsako Central 
Igueben 
Oredo 
Ovia SouthWest 
Ovia South-East 
Orhionwon 
Uhunmwonde 
Etsako East  
Esan South-East 
Ekiti",

@"Ado 
Ekiti-East 
Ekiti-West  
Emure/Ise/Orun 
Ekiti South-West 
Ikare 
Irepodun 
Ijero,  
Ido/Osi 
Oye 
Ikole 
Moba 
Gbonyin 
Efon 
Ise/Orun  
Ilejemeje.",

@"Enugu South,  
Igbo-Eze South 
Enugu North 
Nkanu 
Udi Agwu 
Oji-River 
Ezeagu 
IgboEze North 
Isi-Uzo 
Nsukka 
Igbo-Ekiti 
Uzo-Uwani 
Enugu Eas 
Aninri 
Nkanu East 
Udenu. ",

@"Akko 
Balanga 
Billiri 
Dukku 
Kaltungo 
Kwami 
Shomgom 
Funakaye 
Gombe 
Nafada/Bajoga  
Yamaltu/Delta.",

@"Aboh-Mbaise 
Ahiazu-Mbaise 
Ehime-Mbano 
Ezinihitte 
Ideato North 
Ideato South 
Ihitte/Uboma 
Ikeduru 
Isiala Mbano 
Isu 
Mbaitoli 
Mbaitoli 
Ngor-Okpala 
Njaba 
Nwangele 
Nkwerre 
Obowo 
Oguta 
Ohaji/Egbema 
Okigwe 
Orlu 
Orsu 
Oru East 
Oru West 
Owerri-Municipal 
Owerri North 
Owerri West ",

@"Auyo 
Babura 
Birni Kudu 
Biriniwa 
Buji 
Dutse 
Gagarawa 
Garki 
Gumel 
Guri 
Gwaram 
Gwiwa 
Hadejia 
Jahun 
Kafin Hausa 
Kaugama Kazaure 
Kiri Kasamma 
Kiyawa 
Maigatari 
Malam Madori 
Miga 
Ringim 
Roni 
Sule-Tankarkar 
Taura  
Yankwashi ",

@"Birni-Gwari 
Chikun 
Giwa 
Igabi 
Ikara 
jaba 
Jema'a 
Kachia 
Kaduna North 
Kaduna South 
Kagarko 
Kajuru 
Kaura 
Kauru 
Kubau 
Kudan 
Lere 
Makarfi 
Sabon-Gari 
Sanga 
Soba 
Zango-Kataf 
Zaria ",

@"Ajingi 
Albasu 
Bagwai 
Bebeji 
Bichi 
Bunkure 
Dala 
Dambatta 
Dawakin Kudu 
Dawakin Tofa 
Doguwa 
Fagge 
Gabasawa 
Garko 
Garum 
Mallam 
Gaya 
Gezawa 
Gwale 
Gwarzo 
Kabo 
Kano Municipal 
Karaye 
Kibiya 
Kiru 
kumbotso 
Kunchi 
Kura 
Madobi 
Makoda 
Minjibir 
Nasarawa 
Rano 
Rimin Gado 
Rogo 
Shanono 
Sumaila 
Takali 
Tarauni 
Tofa 
Tsanyawa 
Tudun Wada 
Ungogo 
Warawa 
Wudil",

@"Bakori 
Batagarawa 
Batsari 
Baure 
Bindawa 
Charanchi 
Dandume 
Danja 
Dan Musa 
Daura 
Dutsi 
Dutsin-Ma 
Faskari 
Funtua 
Ingawa 
Jibia 
Kafur 
Kaita 
Kankara 
Kankia 
Katsina 
Kurfi 
Kusada 
Mai'Adua 
Malumfashi 
Mani 
Mashi 
Matazuu 
Musawa 
Rimi 
Sabuwa 
Safana 
Sandamu 
Zango ",

@"Aleiro 
Arewa-Dandi 
Argungu 
Augie 
Bagudo 
Birnin Kebbi 
Bunza 
Dandi  
Fakai 
Gwandu 
Jega 
Kalgo  
Koko/Besse 
Maiyama 
Ngaski 
Sakaba 
Shanga 
Suru 
Wasagu/Danko 
Yauri 
Zuru ",

@"Adavi 
Ajaokuta 
Ankpa 
Bassa 
Dekina 
Ibaji 
Idah 
Igalamela-Odolu 
Ijumu 
Kabba/Bunu 
Kogi 
Lokoja 
Mopa-Muro 
Ofu 
Ogori/Mangongo 
Okehi 
Okene 
Olamabolo 
Omala 
Yagba East  
Yagba West",

@"Asa 
Baruten 
Edu 
Ekiti 
Ifelodun 
Ilorin East 
Ilorin West 
Irepodun 
Isin 
Kaiama 
Moro 
Offa 
Oke-Ero 
Oyun 
Pategi ",

@"Agege 
Ajeromi-Ifelodun 
Alimosho 
Amuwo-Odofin 
Apapa 
Badagry 
Epe 
Eti-Osa 
Ibeju/Lekki 
Ifako-Ijaye  
Ikeja 
Ikorodu 
Kosofe 
Lagos Island 
Lagos Mainland 
Mushin 
Ojo 
Oshodi-Isolo 
Shomolu 
Surulere",

@"Akwanga 
Awe 
Doma 
Karu 
Keana 
Keffi 
Kokona 
Lafia 
Nasarawa 
Nasarawa-Eggon 
Obi 
Toto 
Wamba ",

@"Agaie 
Agwara 
Bida 
Borgu 
Bosso 
Chanchaga 
Edati 
Gbako 
Gurara 
Katcha 
Kontagora  
Lapai 
Lavun 
Magama 
Mariga 
Mashegu 
Mokwa 
Muya 
Pailoro 
Rafi 
Rijau 
Shiroro 
Suleja 
Tafa 
Wushishi",

@"Abeokuta North 
Abeokuta South 
Ado-Odo/Ota 
Egbado North 
Egbado South 
Ewekoro 
Ifo 
Ijebu East 
Ijebu North 
Ijebu North East 
Ijebu Ode 
Ikenne 
Imeko-Afon 
Ipokia 
Obafemi-Owode 
Ogun Waterside 
Odeda 
Odogbolu 
Remo North 
Shagamu",

@"Akoko North East 
Akoko North West 
Akoko South Akure East 
Akoko South West 
Akure North 
Akure South 
Ese-Odo 
Idanre 
Ifedore 
Ilaje 
Ile-Oluji 
Okeigbo 
Irele 
Odigbo 
Okitipupa 
Ondo East 
Ondo West 
Ose 
Owo ",

@"Aiyedade 
Aiyedire 
Atakumosa East 
Atakumosa West 
Boluwaduro 
Boripe 
Ede North 
Ede South 
Egbedore 
Ejigbo 
Ife Central 
Ife East 
Ife North 
Ife South 
Ifedayo 
Ifelodun 
Ila 
Ilesha East 
Ilesha West 
Irepodun 
Irewole 
Isokan 
Iwo 
Obokun 
Odo-Otin 
Ola-Oluwa 
Olorunda 
Oriade 
Orolu 
Osogbo",

@"Afijio 
Akinyele 
Atiba 
Atigbo 
Egbeda 
IbadanCentral 
Ibadan North 
Ibadan North West 
Ibadan South East 
Ibadan South West 
Ibarapa Central 
Ibarapa East 
Ibarapa North 
Ido 
Irepo 
Iseyin 
Itesiwaju 
Iwajowa 
Kajola 
Lagelu Ogbomosho North 
Ogbmosho South 
Ogo Oluwa 
Olorunsogo 
Oluyole 
Ona-Ara 
Orelope 
Ori Ire 
Oyo East 
Oyo West 
Saki East 
Saki West 
Surulere",

@"Barikin Ladi 
Bassa 
Bokkos 
Jos East 
Jos North 
Jos South 
Kanam 
Kanke 
Langtang North 
Langtang South 
Mangu 
Mikang 
Pankshin 
Qua'an Pan 
Riyom 
Shendam 
Wase",

@"Abua/Odual 
Ahoada East 
Ahoada West 
Akuku Toru 
Andoni 
Asari-Toru 
Bonny 
Degema 
Emohua 
Eleme 
Etche 
Gokana 
Ikwerre 
Khana 
Obia/Akpor 
Ogba/Egbema/Ndoni 
Ogu/Bolo 
Okrika 
Omumma 
Opobo/Nkoro 
Oyigbo 
Port-Harcourt 
Tai ",

@"Binji 
Bodinga 
Dange-shnsi 
Gada 
Goronyo 
Gudu 
Gawabawa 
Illela 
Isa 
Kware 
kebbe 
Rabah 
Sabon birni 
Shagari 
Silame 
Sokoto North 
Sokoto South 
Tambuwal 
Tqngaza 
Tureta 
Wamako 
Wurno 
Yabo",

@"Ardo-kola 
Bali 
Donga 
Gashaka 
Cassol 
Ibi 
Jalingo 
Karin-Lamido 
Kurmi 
Lau 
Sardauna 
Takum 
Ussa 
Wukari 
Yorro 
Zing",

@"Bade 
Bursari 
Damaturu 
Fika 
Fune 
Geidam 
Gujba 
Gulani 
Jakusko 
Karasuwa 
Karawa 
Machina 
Nangere 
Nguru Potiskum 
Tarmua 
Yunusari 
Yusufari",
            
@"Anka  
Bakura 
Birnin Magaji 
Bukkuyum 
Bungudu 
Gummi 
Gusau 
Kaura 
Namoda 
Maradun 
Maru 
Shinkafi 
Talata Mafara 
Tsafe 
Zurmi "
    };


    static void InitializeStateZone()
        {
            
            ZoneStateMenu:
                WriteLine($@"For geopolitical in Nigeria press 1                          For States in Nigeria and its FCT, press 2");
                int initialReply = int.Parse(ReadLine());


            if (initialReply == 1 || initialReply == 2)
            {
                
                    if (initialReply == 1)
                    {   
                        AnotherZone:
                            WriteLine($@"Listed below are the geopolitical zones in Nigeria.
            To see states in a zone, please enter it's corresponding number. i.e 1 is for North Central States 
        {nigerianZones}");
                            ZoneReply:
                                int zoneReply = int.Parse(ReadLine());
                        
                    if (zoneReply >= 1 && zoneReply <= 6)
                    {
                        if (zoneReply != null)
                        {
                            string result = stateInZones[zoneReply];
                            WriteLine($"{result}");
                        }
                        
                        WriteLine($"Would you like to check another zone? Yes[Y] / N[No]");
                        string anotherZoneReply = ReadLine().ToUpper();
                        if (anotherZoneReply == "Y")
                        {
                            goto AnotherZone;
                        }
                        else if (anotherZoneReply == "N")
                        {
                            goto ZoneStateMenu;
                        }
     
                    }
                    else
                    {
                        WriteLine("Please enter a valid number. I.e 1"); 
                        goto ZoneReply;
                    }

                }
                else if (initialReply == 2)
                {
                    AnotherState:
                        WriteLine($@"Listed below are the 36 states in Nigeria.
    To see local government areas in each state, please enter it's corresponding number. i.e 1 is for Abia State
    {nigerianStates}");
                        
                        StateReply:
                        int stateReply = int.Parse(ReadLine());
                        
                    if (stateReply >= 1 && stateReply <= 37)
                    {
                        if (stateReply != null)
                        {
                            string result = localGovernts[stateReply];
                            WriteLine($"{result}");
                        }
                        
                        WriteLine($"Would you like to check the local government areas in another state? Yes[Y] / N[No]");
                        string anotherStateReply = ReadLine().ToUpper();
                        if (anotherStateReply == "Y")
                        {
                            goto AnotherState;
                        }
                        else if (anotherStateReply == "N")
                        {
                            goto ZoneStateMenu;
                        }
     
                    }
                    else
                    {
                        WriteLine("Please enter a valid number. I.e 1"); 
                        goto StateReply;
                    }
                    
                }
            }
            else
            {
                WriteLine("Please enter a valid number. I.e 1");
                goto ZoneStateMenu;
            }


        }
    }
}