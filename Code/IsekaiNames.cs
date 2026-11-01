using System;
using NCMS;
using NCMS.Utils;

namespace Isekai
{
    class IsekaiNames
    {
        public static void init(){
          Names();
        }

        public static void Names()
        {

          //Japan
          
          NameGeneratorAsset japan_kingdom = new NameGeneratorAsset();
          japan_kingdom.id = "japan_kingdom";
          japan_kingdom.use_dictionary = true;
		      japan_kingdom.motto_parts.Add("first", "Nippon,Nihon");
          japan_kingdom.motto_parts.Add("space", " ");
          japan_kingdom.motto_parts.Add("second", "Koku");
          japan_kingdom.templates.Add("first,space,second");
          japan_kingdom.templates.Add("first");
          AssetManager.nameGenerator.add(japan_kingdom);

        NameGeneratorAsset japan_city = new NameGeneratorAsset();
        japan_city.id = "japan_city";
		    japan_city.part_groups.Add("Tokyo,Yokohama,Osaka,Nagoya,Sapporo,Fukuoka,Kobe,Kawasaki,Kyoto,Hiroshima,Sendai,Chiba,Kitakyushu,Aomori,Akita,Yamagata,Fukushima,Mito,Utsunomiya,Maebashi,Urawa,Kofu,Nagano,Niigata,Toyama,Kanazawa,Fukui,Gifu,Shizuoka,Tsu,Otsu,Nara,Wakayama,Tottori,Matsue,Okayama,Yamaguchi,Tokushima,Takamatsu,Matsuyama,Kochi,Saga,Nagasaki,Kumamoto,Oita,Miyazaki,Kagoshima,Naha");
		    japan_city.templates.Add("part_group");
        AssetManager.nameGenerator.add(japan_city);

		      NameGeneratorAsset japan_name = new NameGeneratorAsset();
          japan_name.id = "japan_name";
          japan_name.part_groups.Add("Yuri,Akira,Koda,Yuki,Naruto,Yudi,Gohan,Shin,Hiroshi,Itachi,Goku,Ken,Sasuke,Hideki,Takashi,Kurama,Iori,Katsuo,Hayato,Raiden,Ren,Fuyuki,Takeshi,Yoshiaki,Kazumi,Seiji,Riki,Yoshi,Ichiro,Kanji,Kazuo,Satoru,Kenji,Koji,Tatsuo,Hideaki,Kenichi,Miyako,Hiroki,Ume,Kotaro,Yasuhiko,Kakashi,Gaara,Nakamura,Shinichi,Natsu,Kazuaki,Isao,Kentaro,Daichi,Kenjiro,Shuichi,Yachi,Boruto,Kento,Ryotaro,Kiichi,Susumo,Kobayashi,Yamamoto,Takafumi,Hiroito,Hidetaka,Neji,Watanabe,Anon,Shikamaru");
          japan_name.part_groups.Add(" ");
          japan_name.part_groups.Add("Watanabe,Watanabe,Saito,Yoshida,Yamazaki,Kobayashi,Tanaka,Takahashi,Suzuki,Suzuki,Murakami,Honda,Miyazaki,Ono,Toyota,Ozu,Hashimoto,Shinkai,Kato,Tamura,Kaneko,Taniguchi,Koyama,Kinoshita,Kurosawa,Oshiro,Yukimura,Mizushima,Shotoku");
          japan_name.part_groups2.Add("Kira,Naomi,Ayumi,Yumi,Mahina,Sayuri,Yuna,Mayumi,Nara,Hana,Akemi,Hinata,Mari,Aiko,Sakura,Saori,Yoko,Emi,Saionara,Harumi,Keiko,Mina,Yoki,Tsunade,Yasu,Kimi,Kin,Kami,Himawari,Maisha,Kyoko,Kiara,Ky,Mizuki,Aika,Mikasa,Yuno,Mei,Mimi,Yua,Isoko,Sawako,Sawako,You");
          japan_name.part_groups2.Add(" ");
          japan_name.part_groups2.Add("Watanabe,Watanabe,Saito,Yoshida,Yamazaki,Kobayashi,Tanaka,Takahashi,Suzuki,Suzuki,Murakami,Honda,Miyazaki,Ono,Toyota,Ozu,Hashimoto,Shinkai,Kato,Tamura,Kaneko,Taniguchi,Koyama,Kinoshita,Kurosawa,Oshiro,Yukimura,Mizushima,Shotoku");
          japan_name.templates.Add("part_group");
          japan_name.templates.Add("part_group2");
          AssetManager.nameGenerator.add(japan_name);

        NameGeneratorAsset japan_clan = new NameGeneratorAsset();
        japan_clan.id = "japan_clan";
		    japan_clan.part_groups.Add("Watanabe,Watanabe,Saito,Yoshida,Yamazaki,Kobayashi,Tanaka,Takahashi,Suzuki,Suzuki,Murakami,Honda,Miyazaki,Ono,Toyota,Ozu,Hashimoto,Shinkai,Kato,Tamura,Kaneko,Taniguchi,Koyama,Kinoshita,Kurosawa,Oshiro,Yukimura,Mizushima,Shotoku");
		    japan_clan.templates.Add("part_group");
        AssetManager.nameGenerator.add(japan_clan);

        //Chinese

          NameGeneratorAsset china_city = new NameGeneratorAsset();
          china_city.id = "china_city";
          china_city.use_dictionary = true;
          china_city.motto_parts.Add("primeiro", "Anqing,Beihai,Changsha,Dalian,Fuzhou,Guangzhou,Hangzhou,Guiyang,Harbin,Jinan,Kunming,Lanzhou,Mianyang,Nanchang,Nanjing,Qingdao,Shantou,Suzhou,Tianjin,Urumqi,Weifang,Xiamen,Yangzhou,Zhengzhou,Changzhou,Hefei,Xi'an,Wuhan,Chengdu,Shanghai,Beijing,Guangzhou,Shenzhen,Chongqing,Tianjin,Xi'an,Shenyang,Nanjing,Harbin,Kunming,Hefei,Zhengzhou,Changsha,Hangzhou,Suzhou,Wuhan,Qingdao,Chengdu,Dalian,Nanning,Guiyang,Yinchuan,Wuxi,Fuzhou,Jinan,Ningbo,Zhuhai,Xiamen,Taizhou,Yantai,Changchun,Zibo,Shijiazhuang,Haikou,Hohhot,Taiyuan,Luoyang,Xining,Lanzhou,Shantou,Datong,Yangzhou,Lianyungang,Xuzhou,Tongliao,Weifang,Anshan,Huizhou,Chifeng,Jining,Linyi,Huai'an,Wenzhou,Yangjiang,Jining,Hefei,Xinyang,Dongguan,Weifang,Huai'an,Anshan,Taizhou,Kaifeng,Chifeng,Xinyu,Xiaogan,Yingkou,Luoyang,Anqing,Zhumadian,Zhangzhou,Tianshui,Yichun,Xinghua,Putian,Xiangyang,Heyuan,Panjin,Zhoushan,Luohe,Loudi,Suining,Tongling,Daqing,Qujing,Huludao,Yueyang,Yulin,Huizhou,Xinyi,Xianning,Shishi,Hegang,Yangquan,Heze,Yongzhou,Yuxi,Jincheng,Liaocheng,Xichang,Xinzhou,Yibin,Fuxin,Jiamusi,Jieyang,Loudi,Meishan,Jiaxing,Chuzhou,Shangqiu,Zhangqiao,Xinyi,Xianning,Qinhuangdao,Hengyang,Weifang,Wafangdian,Tieling,Jingmen,Wuyishan,Yulin,Xinyang,Chaozhou,Jinjiang,Guangyuan,Pingdingshan,Anqing,Huaian,Quanzhou,Xiamen,Tongchuan,Yichun,Liuzhou,Liaocheng,Benxi,Wuwei,Baoding,Xiantao,Xiangtan,Tianshui,Xinghua,Chengde,Jilin,Jinzhou,Xinyang,Zhuzhou,Suining,Yuxi,Wuhan,Lishui,Liyang,Shaoxing");
		      china_city.motto_parts.Add("segundo", "Xiaogan,Zhangjiakou,Chaozhou,Shangqiu,Xilinhot,Shizuishan,Chizhou,Qinzhou,Jinjiang,Yangquan,Zhaotong,Zhumadian,Suqian,Shaoyang,Huainan,Yingkou,Xinyang,Pingliang,Yinchuan,Zhangzhou,Huludao,Chongzuo,Xingyi,Tongren,Baishan,Xilinhaote,Baiyin,Changzhi,Qingyuan,Xiangtan,Jiamusi,Chifeng,Laibin,Lishui,Puyang,Xiaoshan,Jieyang,Xiaoyi,Shangrao,Meishan,Dingzhou,Suining,Qiqihar,Dunhuang,Lu'an,Heze,Yingtan,Xinghua,Linhai,Zunyi,Nanping,Zhucheng,Jincheng,Zhanjiang,Yan'an,Liangshan,Shangluo,Baiyin,Bazhong,Guilin,Xinxiang,Tongren,Shiyan,Xinyang,Heyuan,Changshu,Yuncheng,Luohe,Xiangyang,Xiaogan,Jiamusi,Shihezi,Qitaihe,Loudi,Tianshui,Anqing,Qianjiang,Lishui,Xichang,Wenshan,Chizhou,Xingyi,Xinzhou,Tongchuan,Zhuzhou,Chifeng,Liuzhou,Shangqiu,Huludao,Guangyuan,Lianyungang,Huanggang,Hanzhong,Guang'an,Yibin,Huaibei,Xinghua,Baise,Baicheng,Baoji,Qingyang,Hegang,Yangquan,Chuzhou,Zhangye,Yichang,Jiamusi,Lishui,Heyuan,Chenzhou,Qionghai,Xinyi,Qitaihe,Yakeshi,Daqing,Shaoyang,Enshi,Yulin,Ankang,Xingyi,Xinzhou,Yongzhou,Anshun,Qianjiang,Shiyan,Yuxi,Weifang,Baise,Hengyang,Dezhou,Shaoxing,Bengbu,Qinzhou,Anqing,Xianning,Baoding,Wuzhou,Bayannur,Jinzhong,Baoshan,Shangrao,Yibin,Xinyang,Xingan,Xianning,Nanping,Zhongshan,Zhoushan,Meizhou,Suizhou,Chongzuo,Tongren,Jingzhou,Xiaogan,Wuzhishan,Shangqiu,Jiayuguan,Wuxi,Meishan,Quzhou,Shihezi,Meihekou,Yancheng,Puqi,Yunfu,Chuzhou,Wuhai,Heyuan,Longyan,Baoshan,Baotou,Xiantao,Zhangye,Xinyang,Loudi,Shaoyang,Yibin,Yanchi,Weifang");
		      china_city.motto_parts.Add("terceiro", "Jinzhou,Shaoguan,Yanji,Tianshui,Lijiang,Datong,Huludao,Pingdingshan,Chifeng,Yueyang,Tongren,Xiangyang,Xiaogan,Yixing,Taizhou,Jinjiang,Yulin,Huaian,Zhaoqing,Anqing,Luoyang,Jieyang,Xuchang,Jiamusi,Zigong,Jilin,Yuxi,Xinyi,Jieyang,Tongling,Xinyang,Yancheng,Panzhihua,Liupanshui,Wuhai,Wenshan,Qinzhou,Huludao,Shangrao,Linfen,Bijie,Fuxin,Zhuhai,Loudi,Suizhou,Heyuan,Zhuzhou,Shaoguan,Yibin,Zhongshan,Rizhao,Huaibei,Xuancheng,Qitaihe,Yangquan,Yinchuan,Chuzhou,Lianyungang,Shuozhou,Huangshan,Dandong,Suqian,Ganzhou,Shanwei,Baicheng,Anqing,Longyan,Quzhou,Xinzhou,Xiangtan,Jiamusi,Jincheng,Yingtan,Jingdezhen,Hegang,Taizhou,Jining,Zhuhai,Xinxiang,Wuzhou,Panjin,Yulin,Yinchuan,Lianyungang,Shaoguan,Xiangyang,Neijiang,Huaihua,Chuzhou,Jiamusi,Shangqiu,Qinzhou,Yangquan,Yangjiang,Qionghai,Yichang,Xinyang,Zhangzhou,Zhumadian,Tonghua,Zhangjiagang,Qujing,Hezhou,Xinyu,Shihezi,Shaoyang,Yichun,Chifeng,Suining,Jieyang,Yueyang,Anshun,Huizhou,Chizhou,Xuancheng,Hefei,Shangluo,Yan'an,Yichun,Loudi,Longyan,Xianyang,Jinjiang,Zhoushan,Bengbu,Huaibei,Zibo,Taian,Baoding,Qingyuan,Anqing,Yuxi,Changde,Xingtai,Xiantao,Suizhou,Ji'an,Hanzhong,Shangrao,Xinyang,Luoyang,Xiangtan,Jiujiang,Linfen,Putian,Hengyang,Zhangjiajie,Zunyi,Hulunbuir,Heihe,Xingyi,Yuncheng,Huainan,Deyang,Meizhou,Guilin,Xinyi,Meihekou,Zhoukou,Changzhi,Zhucheng,Tengzhou,Xinghua,Xiangcheng,Xinzheng,Yunyang,Meishan,Jining,Zhangye,Liupanshui,Changshu,Huaying,Xichang,Meißen,Lishui");
		      china_city.motto_parts.Add("quarto", "Changde,Chizhou,Dezhou,Enshi,Foshan,Handan,Heze,Jilin,Kashi,Laibin,Linyi,Maoming,Ningbo,Panzhihua,Qingyuan,Rizhao,Sanya,Taiyuan,Wanning,Xiangyang,Yichang,Zhangzhou,Anshan,Baicheng,Chongzuo,Daqing,Ezhou,Fuyang,Ganzhou,Huangshan,Jiamusi,Korla,Leshan,Mudanjiang,Nanping,Puyang,Qinzhou,Shangqiu,Taizhou,Weinan,Xingyi,Yaan,Zhaoqing,Changchun,Jinhua,Hanzhong");
		      china_city.templates.Add("primeiro");
		      china_city.templates.Add("segundo");
		      china_city.templates.Add("terceiro");
		      china_city.templates.Add("quarto");
          AssetManager.nameGenerator.add(china_city);

          NameGeneratorAsset china_name = new NameGeneratorAsset();
          china_name.id = "china_name";
          china_name.use_dictionary = true;
          china_name.motto_parts.Add("primeiro", "Ai,Aiguo,Bai,Bingwen,Bo,Bohai,Bojing,Bolin,Boqin,Chang,Changpu,Chao,Chen,Cheng,Chonglin,Chuanli,Da,Delun,Dingxiang,Dong,Donghai,Duyi,Enlai,Fa,Fan,Fang,Feng,Fengge,Fu,Gang,Geming,Gen,Guang,Guangli,Gui,Guiren,Guoliang,Guowei,Guozhi,Hai,Han,He,Heng,Hong,Honghui,Huan,Huang,Hui,Huiliang,Huiqing,Huizhong,Jian,Jiang,Jianguo,Jianjun,Jianyu,Jiayi,Jing,Jingguo,Jinhai,Junjie,Kang,Kai,Lei,Li,Liang,Ling,Liqin,Liu,Liwei,Longwei,Meilin,Mengyao,Mingli,Mingyu,Nianzu,Niu,Peizhi,Peng,Pengfei,Ping,Qi,Qiang,Qiao,Qing,Qingshan,Qingsheng,Qiqiang,Qiu,Quan,Renshu,Rong,Ru,Shan,Shanyuan,Shaoqing,Shen,Shi,Shihong,Shirong,Shoushan,Shun,Shunyuan,Song,Tao,Tengfei,Tingguang,Tingfeng,Wei,Weimin,Weisheng,Weiyuan,Wen,Wencheng,Wenyan,Xianliang,Xiaobo,Xiaodan,Xiaojian,Xiaoli,Xiaosheng,Xiaotong,Xiaosi,Xiaowen,Xing,Xiu,Xue,Xueqin,Yan,Yanlin,Yaoting,Yaozu,Ye,Yi,Ying,Yingjie,Yong,Yongliang,Yongnian,Yongrui,Yongzheng,Yuan,Yuanjun,Yun,Yunru,Yusheng,Zedong,Zemin,Zhaohui,Zhen,Zhengsheng,Zhengzhong,Zhiqiang,Zhong,Zhu,Zian,Zihao,Zixin");
		      china_name.motto_parts.Add("segundo", "Ai,Baozhai,Biyu,Changchang,Chen,Chenguang,Chunhua,Chuntao,Cuifen,Daiyu,Dandan,Dongmei,Ehuang,Fan,Fang,Fenfang,Guang,Hong,Hualing,Huan,Huian,Huifang,Huiling,Huiqing,Jia,Jiao,Jiayi,Jiaying,Jie,Jingfei,Jinghua,Jinjing,Ju,Lan,Lanfen,Lanying,Li,Lifen,Lihua,Lijuan,Liling,Lin,Ling,Liqin,Liqiu,Liu,Luli,Mei,Meifen,Meifeng,Meihui,Meili,Meilin,Meirong,Meixiang,Meixiu,Mingxia,Mingzhu,Niu,Nüying,O-Huang,Ong-Kwang,Peizhi,Qi,Qiang,Qiao,Qiaolian,Qing,Qingge,Qingling,Qingzhao,Qiu,Qiuyue,Rong,Ruolan,Shan,Shu,Shuang,Shuchun,Suyin,Ting,Tung-Mei,Wen,Wenling,Wenqian,Xia,Xiang,Xiaodan,Xiaofan,Xiaohui,Xiaoli,Xiaolian,Xiaoling,Xiaoqing,Xifeng,Xingjuan,Xiu,Xiulan,Xiurong,Xiuying,Xue,Ya,Yan,Yanmei,Yanyu,Ying,Yingtai,Yu,Yuan,Yuanjun,Yue,Yun,Zhenzhen,Zhilan,Zhu,Zongying");
		      china_name.motto_parts.Add("terceiro", "An,Ang,Ao,Au,Au Yeung,Ba,Bai,Ban,Bao,Bau,Bi,Bo,Bu,Cai,Cao,Cha,Chai,Cham,Chan,Chang,Chao,Chau,Che,Cheah,Chee,Chen,Cheng,Cheong,Chern,Cheung,Chew,Chi,Chia,Chiang,Chiao,Chien,Chim,Chin,Ching,Chiong,Chiou,Chiu,Cho,Choi,Chong,Choo,Chou,Chow,Choy,Chu,Chua,Chuang,Chui,Chun,Chung,Cong,Cui,Dai,Dang,Dea,Deng,Ding,Do,Dong,Doo,Du,Duan,Dung,Eng,Fan,Fang,Fei,Feng,Fok,Fong,Foo,Fu,Fung,Gan,Gang,Gao,Gau,Ge,Geng,Go,Goh,Gong,Gu,Guan,Guo,Ha,Hai,Han,Hang,Hao,Hau,He,Ho,Hoh,Hom,Hon,Hong,Hoo,Hou,Hsi,Hsia,Hsiao,Hsieh,Hsiung,Hsu,Hsueh,Hu,Hua,Huang,Hui,Huie,Hum,Hung,Huo,Hwang,Hy,Ing,Jan,Jang,Jen,Jeng,Jeung,Jew,Jia,Jian,Jiang,Jiao,Jim,Jin,Jing,Jo,Joe,Jong,Joo,Jou,Jow,Ju,Jue,Jung,Kam,Kan,Kang,Kao,Kau,Ke,Keng,Kho,Khoo,Kiang,King,Ko,Koh,Kong,Koo,Kook,Kou,Ku,Kuan,Kuang,Kuk,Kung,Kuo,Kwan,Kwock,Kwok,Kwon,Kwong,Lai,Lam,Lan,Lang,Lao,Lau,Lee,Lei,Leng,Leong,Leung,Lew,Li,Lian,Liang,Liao,Liaw,Lien,Liew,Lim,Lin,Ling,Liou,Liu,Lo,Loh,Lok,Long,Loo,Lou,Lu,Lung,Luo,Ma,Mah,Mai,Mak,Man,Mao,Mar,Mau,May,Mei,Meng,Miao,Min,Ming,Miu,Mo,Mok,Mon,Mou,Moy,Mu,Mui,Ni,Nie,Ning,Niu,Owyang,Pang,Pei,Peng,Qi,Qian,Qiao,Qin,Qiu,Qu,Quan,Rao,Ren,Rong,Sang,Seto,Sha,Sham,Shan,Shang,Shao,Shaw,Shek,Shen,Sheng,Sheu,Shi,Shiau,Shieh,Shih,Shing,Shiu,Shu,Shum,Shy,Shyu,Si,Sieh,Sin,Sing,Sit,Situ,Siu,So,Soh,Song,Soo,Soo Hoo,Soon,Soong,Su,Suen,Sui,Sum,Sun,Sung,Sze,Szeto,Tai,Tam,Tan,Tang,Tao,Tay,Te,Teh,Teng,Teo,Tian,Tien,Tin,Ting,Tiu,To,Toh,Tom,Tong,Tsai,Tsang,Tsao,Tsay,Tse,Tseng,Tso,Tsoi,Tsou,Tsu,Tsui,Tu,Tuan,Tung,Tzeng,Un,Ung,Wah,Wai,Wan,Wang,Wee,Wei,Wen,Weng,Wing,Wong,Woo,Woon,Wu,Xi,Xia,Xiang,Xiao,Xie,Xin,Xing,Xiong,Xu,Xue,Yam,Yan,Yang,Yao,Yap,Yau,Yaw,Ye,Yee,Yeh,Yen,Yep,Yeung,Yi,Yim,Yin,Ying,Yip,Yiu,Yong,Yoon,You,Young,Yu,Yuan,Yue,Yuen,Yun,Yung,Zang,Zeng,Zha,Zhan,Zhang,Zhao,Zhen,Zheng,Zhong,Zhou,Zhu,Zhuang,Zhuo,Zong,Zou");
          china_name.motto_parts.Add("space", " ");
		      china_name.templates.Add("terceiro,space,primeiro");
		      china_name.templates.Add("terceiro,space,segundo");
          AssetManager.nameGenerator.add(china_name);

        NameGeneratorAsset china_clan = new NameGeneratorAsset();
        china_clan.id = "china_clan";
		    china_clan.part_groups.Add("An,Ang,Ao,Au,Au Yeung,Ba,Bai,Ban,Bao,Bau,Bi,Bo,Bu,Cai,Cao,Cha,Chai,Cham,Chan,Chang,Chao,Chau,Che,Cheah,Chee,Chen,Cheng,Cheong,Chern,Cheung,Chew,Chi,Chia,Chiang,Chiao,Chien,Chim,Chin,Ching,Chiong,Chiou,Chiu,Cho,Choi,Chong,Choo,Chou,Chow,Choy,Chu,Chua,Chuang,Chui,Chun,Chung,Cong,Cui,Dai,Dang,Dea,Deng,Ding,Do,Dong,Doo,Du,Duan,Dung,Eng,Fan,Fang,Fei,Feng,Fok,Fong,Foo,Fu,Fung,Gan,Gang,Gao,Gau,Ge,Geng,Go,Goh,Gong,Gu,Guan,Guo,Ha,Hai,Han,Hang,Hao,Hau,He,Ho,Hoh,Hom,Hon,Hong,Hoo,Hou,Hsi,Hsia,Hsiao,Hsieh,Hsiung,Hsu,Hsueh,Hu,Hua,Huang,Hui,Huie,Hum,Hung,Huo,Hwang,Hy,Ing,Jan,Jang,Jen,Jeng,Jeung,Jew,Jia,Jian,Jiang,Jiao,Jim,Jin,Jing,Jo,Joe,Jong,Joo,Jou,Jow,Ju,Jue,Jung,Kam,Kan,Kang,Kao,Kau,Ke,Keng,Kho,Khoo,Kiang,King,Ko,Koh,Kong,Koo,Kook,Kou,Ku,Kuan,Kuang,Kuk,Kung,Kuo,Kwan,Kwock,Kwok,Kwon,Kwong,Lai,Lam,Lan,Lang,Lao,Lau,Lee,Lei,Leng,Leong,Leung,Lew,Li,Lian,Liang,Liao,Liaw,Lien,Liew,Lim,Lin,Ling,Liou,Liu,Lo,Loh,Lok,Long,Loo,Lou,Lu,Lung,Luo,Ma,Mah,Mai,Mak,Man,Mao,Mar,Mau,May,Mei,Meng,Miao,Min,Ming,Miu,Mo,Mok,Mon,Mou,Moy,Mu,Mui,Ni,Nie,Ning,Niu,Owyang,Pang,Pei,Peng,Qi,Qian,Qiao,Qin,Qiu,Qu,Quan,Rao,Ren,Rong,Sang,Seto,Sha,Sham,Shan,Shang,Shao,Shaw,Shek,Shen,Sheng,Sheu,Shi,Shiau,Shieh,Shih,Shing,Shiu,Shu,Shum,Shy,Shyu,Si,Sieh,Sin,Sing,Sit,Situ,Siu,So,Soh,Song,Soo,Soo Hoo,Soon,Soong,Su,Suen,Sui,Sum,Sun,Sung,Sze,Szeto,Tai,Tam,Tan,Tang,Tao,Tay,Te,Teh,Teng,Teo,Tian,Tien,Tin,Ting,Tiu,To,Toh,Tom,Tong,Tsai,Tsang,Tsao,Tsay,Tse,Tseng,Tso,Tsoi,Tsou,Tsu,Tsui,Tu,Tuan,Tung,Tzeng,Un,Ung,Wah,Wai,Wan,Wang,Wee,Wei,Wen,Weng,Wing,Wong,Woo,Woon,Wu,Xi,Xia,Xiang,Xiao,Xie,Xin,Xing,Xiong,Xu,Xue,Yam,Yan,Yang,Yao,Yap,Yau,Yaw,Ye,Yee,Yeh,Yen,Yep,Yeung,Yi,Yim,Yin,Ying,Yip,Yiu,Yong,Yoon,You,Young,Yu,Yuan,Yue,Yuen,Yun,Yung,Zang,Zeng,Zha,Zhan,Zhang,Zhao,Zhen,Zheng,Zhong,Zhou,Zhu,Zhuang,Zhuo,Zong,Zou");
		    china_clan.templates.Add("part_group");
        AssetManager.nameGenerator.add(china_clan);

        NameGeneratorAsset china_kingdom = new NameGeneratorAsset();
          china_kingdom.id = "china_kingdom";
          china_kingdom.use_dictionary = true;
          china_kingdom.motto_parts.Add("primeiro", "Dynasty");
		      china_kingdom.motto_parts.Add("segundo", "An,Ang,Ao,Au,Au Yeung,Ba,Bai,Ban,Bao,Bau,Bi,Bo,Bu,Cai,Cao,Cha,Chai,Cham,Chan,Chang,Chao,Chau,Che,Cheah,Chee,Chen,Cheng,Cheong,Chern,Cheung,Chew,Chi,Chia,Chiang,Chiao,Chien,Chim,Chin,Ching,Chiong,Chiou,Chiu,Cho,Choi,Chong,Choo,Chou,Chow,Choy,Chu,Chua,Chuang,Chui,Chun,Chung,Cong,Cui,Dai,Dang,Dea,Deng,Ding,Do,Dong,Doo,Du,Duan,Dung,Eng,Fan,Fang,Fei,Feng,Fok,Fong,Foo,Fu,Fung,Gan,Gang,Gao,Gau,Ge,Geng,Go,Goh,Gong,Gu,Guan,Guo,Ha,Hai,Han,Hang,Hao,Hau,He,Ho,Hoh,Hom,Hon,Hong,Hoo,Hou,Hsi,Hsia,Hsiao,Hsieh,Hsiung,Hsu,Hsueh,Hu,Hua,Huang,Hui,Huie,Hum,Hung,Huo,Hwang,Hy,Ing,Jan,Jang,Jen,Jeng,Jeung,Jew,Jia,Jian,Jiang,Jiao,Jim,Jin,Jing,Jo,Joe,Jong,Joo,Jou,Jow,Ju,Jue,Jung,Kam,Kan,Kang,Kao,Kau,Ke,Keng,Kho,Khoo,Kiang,King,Ko,Koh,Kong,Koo,Kook,Kou,Ku,Kuan,Kuang,Kuk,Kung,Kuo,Kwan,Kwock,Kwok,Kwon,Kwong,Lai,Lam,Lan,Lang,Lao,Lau,Lee,Lei,Leng,Leong,Leung,Lew,Li,Lian,Liang,Liao,Liaw,Lien,Liew,Lim,Lin,Ling,Liou,Liu,Lo,Loh,Lok,Long,Loo,Lou,Lu,Lung,Luo,Ma,Mah,Mai,Mak,Man,Mao,Mar,Mau,May,Mei,Meng,Miao,Min,Ming,Miu,Mo,Mok,Mon,Mou,Moy,Mu,Mui,Ni,Nie,Ning,Niu,Owyang,Pang,Pei,Peng,Qi,Qian,Qiao,Qin,Qiu,Qu,Quan,Rao,Ren,Rong,Sang,Seto,Sha,Sham,Shan,Shang,Shao,Shaw,Shek,Shen,Sheng,Sheu,Shi,Shiau,Shieh,Shih,Shing,Shiu,Shu,Shum,Shy,Shyu,Si,Sieh,Sin,Sing,Sit,Situ,Siu,So,Soh,Song,Soo,Soo Hoo,Soon,Soong,Su,Suen,Sui,Sum,Sun,Sung,Sze,Szeto,Tai,Tam,Tan,Tang,Tao,Tay,Te,Teh,Teng,Teo,Tian,Tien,Tin,Ting,Tiu,To,Toh,Tom,Tong,Tsai,Tsang,Tsao,Tsay,Tse,Tseng,Tso,Tsoi,Tsou,Tsu,Tsui,Tu,Tuan,Tung,Tzeng,Un,Ung,Wah,Wai,Wan,Wang,Wee,Wei,Wen,Weng,Wing,Wong,Woo,Woon,Wu,Xi,Xia,Xiang,Xiao,Xie,Xin,Xing,Xiong,Xu,Xue,Yam,Yan,Yang,Yao,Yap,Yau,Yaw,Ye,Yee,Yeh,Yen,Yep,Yeung,Yi,Yim,Yin,Ying,Yip,Yiu,Yong,Yoon,You,Young,Yu,Yuan,Yue,Yuen,Yun,Yung,Zang,Zeng,Zha,Zhan,Zhang,Zhao,Zhen,Zheng,Zhong,Zhou,Zhu,Zhuang,Zhuo,Zong,Zou");
          china_kingdom.motto_parts.Add("space", " ");
		      china_kingdom.templates.Add("primeiro,space,segundo");
          AssetManager.nameGenerator.add(china_kingdom);

          NameGeneratorAsset china_culture = new NameGeneratorAsset();
          china_culture.id = "china_culture";
          china_culture.use_dictionary = true;
          china_culture.motto_parts.Add("primeiro", "Culture");
		      china_culture.motto_parts.Add("segundo", "An,Ang,Ao,Au,Au Yeung,Ba,Bai,Ban,Bao,Bau,Bi,Bo,Bu,Cai,Cao,Cha,Chai,Cham,Chan,Chang,Chao,Chau,Che,Cheah,Chee,Chen,Cheng,Cheong,Chern,Cheung,Chew,Chi,Chia,Chiang,Chiao,Chien,Chim,Chin,Ching,Chiong,Chiou,Chiu,Cho,Choi,Chong,Choo,Chou,Chow,Choy,Chu,Chua,Chuang,Chui,Chun,Chung,Cong,Cui,Dai,Dang,Dea,Deng,Ding,Do,Dong,Doo,Du,Duan,Dung,Eng,Fan,Fang,Fei,Feng,Fok,Fong,Foo,Fu,Fung,Gan,Gang,Gao,Gau,Ge,Geng,Go,Goh,Gong,Gu,Guan,Guo,Ha,Hai,Han,Hang,Hao,Hau,He,Ho,Hoh,Hom,Hon,Hong,Hoo,Hou,Hsi,Hsia,Hsiao,Hsieh,Hsiung,Hsu,Hsueh,Hu,Hua,Huang,Hui,Huie,Hum,Hung,Huo,Hwang,Hy,Ing,Jan,Jang,Jen,Jeng,Jeung,Jew,Jia,Jian,Jiang,Jiao,Jim,Jin,Jing,Jo,Joe,Jong,Joo,Jou,Jow,Ju,Jue,Jung,Kam,Kan,Kang,Kao,Kau,Ke,Keng,Kho,Khoo,Kiang,King,Ko,Koh,Kong,Koo,Kook,Kou,Ku,Kuan,Kuang,Kuk,Kung,Kuo,Kwan,Kwock,Kwok,Kwon,Kwong,Lai,Lam,Lan,Lang,Lao,Lau,Lee,Lei,Leng,Leong,Leung,Lew,Li,Lian,Liang,Liao,Liaw,Lien,Liew,Lim,Lin,Ling,Liou,Liu,Lo,Loh,Lok,Long,Loo,Lou,Lu,Lung,Luo,Ma,Mah,Mai,Mak,Man,Mao,Mar,Mau,May,Mei,Meng,Miao,Min,Ming,Miu,Mo,Mok,Mon,Mou,Moy,Mu,Mui,Ni,Nie,Ning,Niu,Owyang,Pang,Pei,Peng,Qi,Qian,Qiao,Qin,Qiu,Qu,Quan,Rao,Ren,Rong,Sang,Seto,Sha,Sham,Shan,Shang,Shao,Shaw,Shek,Shen,Sheng,Sheu,Shi,Shiau,Shieh,Shih,Shing,Shiu,Shu,Shum,Shy,Shyu,Si,Sieh,Sin,Sing,Sit,Situ,Siu,So,Soh,Song,Soo,Soo Hoo,Soon,Soong,Su,Suen,Sui,Sum,Sun,Sung,Sze,Szeto,Tai,Tam,Tan,Tang,Tao,Tay,Te,Teh,Teng,Teo,Tian,Tien,Tin,Ting,Tiu,To,Toh,Tom,Tong,Tsai,Tsang,Tsao,Tsay,Tse,Tseng,Tso,Tsoi,Tsou,Tsu,Tsui,Tu,Tuan,Tung,Tzeng,Un,Ung,Wah,Wai,Wan,Wang,Wee,Wei,Wen,Weng,Wing,Wong,Woo,Woon,Wu,Xi,Xia,Xiang,Xiao,Xie,Xin,Xing,Xiong,Xu,Xue,Yam,Yan,Yang,Yao,Yap,Yau,Yaw,Ye,Yee,Yeh,Yen,Yep,Yeung,Yi,Yim,Yin,Ying,Yip,Yiu,Yong,Yoon,You,Young,Yu,Yuan,Yue,Yuen,Yun,Yung,Zang,Zeng,Zha,Zhan,Zhang,Zhao,Zhen,Zheng,Zhong,Zhou,Zhu,Zhuang,Zhuo,Zong,Zou");
          china_culture.motto_parts.Add("space", " ");
		      china_culture.templates.Add("primeiro,space,segundo");
          AssetManager.nameGenerator.add(china_culture);

          //Androids

          NameGeneratorAsset android_name = new NameGeneratorAsset();
          android_name.id = "android_name";
          android_name.use_dictionary = true;
          android_name.motto_parts.Add("first", "AN,BE,CI,DO,EA,FU,GA,HE,IB,JI,KY,LO,MU,NA,OC,PE,QI,RO,SU,TA,UD,VE,WI,XO,YU,ZA");
          android_name.motto_parts.Add("space", " ");
          android_name.motto_parts.Add("second", "0,1,2,3,4");
          android_name.motto_parts.Add("tres", "5,6,7,8,9");
		      android_name.templates.Add("first,space,second,tres");
          android_name.templates.Add("first,space,second,tres,second");
          android_name.templates.Add("first,space,tres,second,tres,second");
          android_name.templates.Add("first,space,tres,second,tres,second,tres");
          AssetManager.nameGenerator.add(android_name);

          //Gnomes

          NameGeneratorAsset gnome_name = new NameGeneratorAsset();
          gnome_name.id = "gnome_name";
          gnome_name.use_dictionary = true;
          gnome_name.motto_parts.Add("BRA", "Bra");
          gnome_name.motto_parts.Add("BRA2", "ga,ganca,mante,nca,ndao,s,siliana");
          gnome_name.motto_parts.Add("BRE", "Bre");
          gnome_name.motto_parts.Add("BRE2", "no,na,nda,ndo");
          gnome_name.motto_parts.Add("BRI", "Bri");
          gnome_name.motto_parts.Add("BRI2", "cio,cia,gida,gido,tanea,taneo,tes,to,ta,quel,stisno,stisna");
          gnome_name.motto_parts.Add("BRU", "Bru");
          gnome_name.motto_parts.Add("BRU2", "no,na,tos,mal,sco,nilda,nildo");
          gnome_name.motto_parts.Add("BA", "Ba");
          gnome_name.motto_parts.Add("BA2", "bete,celar,lbina,lbino,lbo,lder,lduina,lduino,lsamina,ltasar,mbi,mbui,nanal,rac,rbara,rcelos,riri,rnabe,rreto,rsabe,rsina,rtira,rtolomeu,sileu,siliano,silides,silina,sino,tistina,tistino");
          gnome_name.motto_parts.Add("BE", "Be");
          gnome_name.motto_parts.Add("BE2", "la,lami,lcanto,lchior,leno,nardo,narda,lesis,lgio,lina,linda,lino,lisario,lmira,ltrao,n,nedita,nicia,nicio,nilda,nito,njamim,njamin,no,noni,nta,ntes,nto,raldo,renice,rilo,rnadete,rnardina,rnardino,rnado,rnada,rta,rto,rtold,ss,ssie,tina,tsabe,vilaqua");
          gnome_name.motto_parts.Add("BI", "Bi");
          gnome_name.motto_parts.Add("BI2", "anca,anor,as,rigui,rilo,triz,a,ll,bibiana,lly,smark,spo,riqui,ara,nder,anchi,rgit,ron,rgitta,zet");
          gnome_name.motto_parts.Add("BO", "Bo");
          gnome_name.motto_parts.Add("BO2", "anerges,aventura,caiuva,livar,nafide,nifacio,ris,telho,a,ss,as,tucatu,abdil,car,ecio,cco,gumil,guslau,nar,hn,na,nner,oone,rja,sco,rys,njv,y,i,yd,liere");
          gnome_name.motto_parts.Add("BU", "Bu");
          gnome_name.motto_parts.Add("BU2", "rton,da,d,dha,eno,lbaquer,lhoes,riti,rt,rniera,rnier,rle,no,palo");
          gnome_name.motto_parts.Add("All", "Bra,Bre,Bri,Bru,Ba,Be,Bi,Bo,Bu");
          gnome_name.motto_parts.Add("All2", "ga,ganca,no,na,tos,mal,sco,anerges,aventura,caiuva,livar,nafide,rton,da,d,dha,eno,lbaquer,lhoes,riti,rt,rniera,rnier,rle,no,palo,nifacio,ris,telho,a,ss,as,tucatu,abdil,car,ecio,cco,gumil,guslau,nar,hn,na,nner,oone,rja,sco,rys,njv,y,i,yd,liere,nilda,nildo,mante,nca,anca,anor,as,rigui,rilo,triz,a,ll,bibiana,lly,smark,spo,riqui,ara,nder,anchi,rgit,ron,rgitta,zet,ndao,s,siliana,no,na,nda,ndo,cio,cia,gida,gido,tanea,taneo,tes,to,ta,quel,bete,celar,lbina,lbino,lbo,lder,lduina,lduino,lsamina,ltasar,mbi,mbui,nanal,rac,rbara,rcelos,riri,rnabe,rreto,rsabe,rsina,rtira,rtolomeu,sileu,siliano,silides,silina,sino,tistina,tistino,stisno,stisna,la,lami,lcanto,lchior,leno,nardo,narda,lesis,lgio,lina,linda,lino,lisario,lmira,ltrao,n,nedita,nicia,nicio,nilda,nito,njamim,njamin,no,noni,nta,ntes,nto,raldo,renice,rilo,rnadete,rnardina,rnardino,rnado,rnada,rta,rto,rtold,ss,ssie,tina,tsabe,vilaqua");
          gnome_name.motto_parts.Add("surname", "Badu,Baltar,Baltazar,Bandeira,Barbosa,Barreto,Barros,Barroso,Baseggio,Bastos,Batista,Bermudes,Bernades,Bernardes,Bicalho,Bispo,Bolsonaro,Borba,Borges,Borsoi,Bueno,Bazarelo");
          gnome_name.motto_parts.Add("HA", "Ha");
          gnome_name.motto_parts.Add("HA2", "bib,idê,imon,lina,med,mílcar,milton,níbal,riberto,roldo,rry,ssan,ydée,zael");
          gnome_name.motto_parts.Add("HE", "He");
          gnome_name.motto_parts.Add("HE2", "be,dviges,itor,ládio,lânio,lcio,lder,le,lena,leno,leonora,lga,li,liberto,limenas,lio,heliodo,ll,lma,loísa,nedina,nriqueta,reldo,rbert,rcília,rculano,rcules,riberto,rmann,rmano,rmenegildo,rmengarda,rmes,rmeto,rmínia,rmino,rmon,rodes,ron,rondina,ros,síodo,lária");
          gnome_name.motto_parts.Add("HI", "Hi");
          gnome_name.motto_parts.Add("HI2", "ilda,lária,ldebrando,ldegardo,lderico,lma,lton,ago,ally,an,andra,ara,a,aceles,berval,as,brael,celia,dalgo,deki,deko,delbrando,delgardes,delvan,dely,demburgo,denilsa,deo,detaka,dia,droconcons,dulfo,eda,eida,oda,era,ero,érocles,eto,gino,glelcia,gor,karu");
          gnome_name.motto_parts.Add("HO", "Ho");
          gnome_name.motto_parts.Add("HO2", "mero,norato,norino,rtência,sana,daleia,di,dney,eliana,felia,ffman,fmann,go,guinei,landa,landy,lda,ldai,lden,lderlin,lly,lm,lofernes,mem,mer,nesto,ney,nizia,norina,norinda,norino,nório,norita,norius,nos,pe,race,racelia,racia");
          gnome_name.motto_parts.Add("HU", "Hu");
          gnome_name.motto_parts.Add("HU2", "go,mberto,ff,bner,lse,ses,mmel,else,rtado,we,mmes,llinger,et,rtado,ller,ch,et,ggins,yer,bbard,mphrey,ngria,mbert,tchison,rtere,hn");
          gnome_name.motto_parts.Add("All3", "Ha,He,Hi,Ho,Hu");
          gnome_name.motto_parts.Add("All4", "bib,idê,imon,lina,med,mílcar,milton,níbal,riberto,roldo,rry,ssan,ydée,zael,be,dviges,itor,ládio,lânio,lcio,lder,le,lena,leno,leonora,lga,li,liberto,limenas,lio,heliodo,ll,lma,loísa,nedina,nriqueta,reldo,rbert,rcília,rculano,rcules,riberto,rmann,rmano,rmenegildo,rmengarda,rmes,rmeto,rmínia,rmino,rmon,rodes,ron,rondina,ros,síodo,láriailda,lária,ldebrando,ldegardo,lderico,lma,lton,ago,ally,an,andra,ara,a,aceles,berval,as,brael,celia,dalgo,deki,deko,delbrando,delgardes,delvan,dely,demburgo,denilsa,deo,detaka,dia,droconcons,dulfo,eda,eida,oda,era,ero,érocles,eto,gino,glelcia,gor,karu,mero,norato,norino,rtência,sana,daleia,di,dney,eliana,felia,ffman,fmann,go,guinei,landa,landy,lda,ldai,lden,lderlin,lly,lm,lofernes,mem,mer,nesto,ney,nizia,norina,norinda,norino,nório,norita,norius,nos,pe,race,racelia,racia,go,mberto,ff,bner,lse,ses,mmel,else,rtado,we,mmes,llinger,et,rtado,ller,ch,et,ggins,yer,bbard,mphrey,ngria,mbert,tchison,rtere,hn");
          gnome_name.motto_parts.Add("surname2", "Haab,Haser,Hassel,Haud,Haupt,Helm,Helmmann,Heller,Hellbach,Helfenstein,Held,Heck,Hegen,Heil,Herzer,Hilles,Hinkel,Hirsch,Hockmller,Hoerhann,Hofel,HoffHohl,Holderbaum,Holler,Holmstensdotter,Hols,Hossert,Hubatsch,Huber,Hubinette,Hubner,Hudnof,Hulsmann");
          gnome_name.motto_parts.Add("All5", "Bra,Bre,Bri,Bru,Ba,Be,Bi,Bo,BuHa,He,Hi,Ho,Hu");
          gnome_name.motto_parts.Add("All6", "ga,ganca,no,na,tos,mal,sco,anerges,aventura,caiuva,livar,nafide,rton,da,d,dha,eno,lbaquer,lhoes,riti,rt,rniera,rnier,rle,no,palo,nifacio,ris,telho,a,ss,as,tucatu,abdil,car,ecio,cco,gumil,guslau,nar,hn,na,nner,oone,rja,sco,rys,njv,y,i,yd,liere,nilda,nildo,mante,nca,anca,anor,as,rigui,rilo,triz,a,ll,bibiana,lly,smark,spo,riqui,ara,nder,anchi,rgit,ron,rgitta,zet,ndao,s,siliana,no,na,nda,ndo,cio,cia,gida,gido,tanea,taneo,tes,to,ta,quel,bete,celar,lbina,lbino,lbo,lder,lduina,lduino,lsamina,ltasar,mbi,mbui,nanal,rac,rbara,rcelos,riri,rnabe,rreto,rsabe,rsina,rtira,rtolomeu,sileu,siliano,silides,silina,sino,tistina,tistino,stisno,stisna,la,lami,lcanto,lchior,leno,nardo,narda,lesis,lgio,lina,linda,lino,lisario,lmira,ltrao,n,nedita,nicia,nicio,nilda,nito,njamim,njamin,no,noni,nta,ntes,nto,raldo,renice,rilo,rnadete,rnardina,rnardino,rnado,rnada,rta,rto,rtold,ss,ssie,tina,tsabe,vilaqua,bib,idê,imon,lina,med,mílcar,milton,níbal,riberto,roldo,rry,ssan,ydée,zael,be,dviges,itor,ládio,lânio,lcio,lder,le,lena,leno,leonora,lga,li,liberto,limenas,lio,heliodo,ll,lma,loísa,nedina,nriqueta,reldo,rbert,rcília,rculano,rcules,riberto,rmann,rmano,rmenegildo,rmengarda,rmes,rmeto,rmínia,rmino,rmon,rodes,ron,rondina,ros,síodo,láriailda,lária,ldebrando,ldegardo,lderico,lma,lton,ago,ally,an,andra,ara,a,aceles,berval,as,brael,celia,dalgo,deki,deko,delbrando,delgardes,delvan,dely,demburgo,denilsa,deo,detaka,dia,droconcons,dulfo,eda,eida,oda,era,ero,érocles,eto,gino,glelcia,gor,karu,mero,norato,norino,rtência,sana,daleia,di,dney,eliana,felia,ffman,fmann,go,guinei,landa,landy,lda,ldai,lden,lderlin,lly,lm,lofernes,mem,mer,nesto,ney,nizia,norina,norinda,norino,nório,norita,norius,nos,pe,race,racelia,racia,go,mberto,ff,bner,lse,ses,mmel,else,rtado,we,mmes,llinger,et,rtado,ller,ch,et,ggins,yer,bbard,mphrey,ngria,mbert,tchison,rtere,hn");
          gnome_name.motto_parts.Add("All7", "Badu,Baltar,Baltazar,Bandeira,Barbosa,Barreto,Barros,Barroso,Baseggio,Bastos,Batista,Bermudes,Bernades,Bernardes,Bicalho,Bispo,Bolsonaro,Borba,Borges,Borsoi,Bueno,Bazarelo,Haab,Haser,Hassel,Haud,Haupt,Helm,Helmmann,Heller,Hellbach,Helfenstein,Held,Heck,Hegen,Heil,Herzer,Hilles,Hinkel,Hirsch,Hockmller,Hoerhann,Hofel,HoffHohl,Holderbaum,Holler,Holmstensdotter,Hols,Hossert,Hubatsch,Huber,Hubinette,Hubner,Hudnof,Hulsmann");
          gnome_name.motto_parts.Add("space", " ");
          gnome_name.templates.Add("BRA,BRA2");
          gnome_name.templates.Add("BRA,BRA2,space,surname");
          gnome_name.templates.Add("BRE,BRE2");
          gnome_name.templates.Add("BRE,BRE2,space,surname");
          gnome_name.templates.Add("BRI,BRI2");
          gnome_name.templates.Add("BRI,BRI2,space,surname");
          gnome_name.templates.Add("BRU,BRU2");
          gnome_name.templates.Add("BRU,BRU2,space,surname");
          gnome_name.templates.Add("BA,BA2");
          gnome_name.templates.Add("BA,BA2,space,surname");
          gnome_name.templates.Add("BE,BE2");
          gnome_name.templates.Add("BE,BE2,space,surname");
          gnome_name.templates.Add("BI,BI2");
          gnome_name.templates.Add("BI,BI2,space,surname");
          gnome_name.templates.Add("BO,BO2");
          gnome_name.templates.Add("BO,BO2,space,surname");
          gnome_name.templates.Add("BU,BU2");
          gnome_name.templates.Add("BU,BU2,space,surname");
          gnome_name.templates.Add("All,All2");
          gnome_name.templates.Add("All,All2,space,surname");
          gnome_name.templates.Add("HA,HA2");
          gnome_name.templates.Add("HA,HA2,space,surname2");
          gnome_name.templates.Add("HE,HE2");
          gnome_name.templates.Add("HE,HE2,space,surname2");
          gnome_name.templates.Add("HI,HI2");
          gnome_name.templates.Add("HI,HI2,space,surname2");
          gnome_name.templates.Add("HO,HO2");
          gnome_name.templates.Add("HO,HO2,space,surname2");
          gnome_name.templates.Add("HU,HU2");
          gnome_name.templates.Add("HU,HU2,space,surname2");
          gnome_name.templates.Add("All3,All4");
          gnome_name.templates.Add("All3,All4,space,surname2");
          gnome_name.templates.Add("All5,All6");
          gnome_name.templates.Add("All5,All6,space,All7");
          AssetManager.nameGenerator.add(gnome_name);

          //Demonic

          NameGeneratorAsset demonic_name = new NameGeneratorAsset();
          demonic_name.id = "demonic_name";
          demonic_name.use_dictionary = true;
          demonic_name.motto_parts.Add("FA", "Fa");
          demonic_name.motto_parts.Add("FA2", "biana,biano,bio,brício,gundes,lcão,tima,usta,ustina,usto,uzi,aria,baino,ber,berly,bi,bia,bian,biande,biane,biani,biela,bien,bielle,bieli,biele,bline,brini,brinny,brisia,brizia,brizio,bron,byane");
          demonic_name.motto_parts.Add("FE", "Fe");
          demonic_name.motto_parts.Add("FE2", "derico,lícia,liciana,lipe,lisbela,lisberto,lix,rdinando,rnandes,rnando,ron,fe,arnot,be,bo,dalto,dato,dele,don,dra,dro,dus,geuijó,io,ital,itosa,lênio,lia,lice,lícia,lician,liciana,liciano,licidade,lício,licis,licíssima,licíssimo,limina,lipa,lipe,pao,pinho,liphe,lippa,lippe,liquex,lisa,lisbela");
          demonic_name.motto_parts.Add("FI", "Fi");
          demonic_name.motto_parts.Add("FI2", "del,delino,gueiredo,filadelfo,léas,lemon,lipe,lomena,rmina,rmino,ácria,ácrio,alho,amma,del,delia,delina,delino,délio,delir,delis,delius,dência,denciano,dêncio,diene,denzio,fides,dias,dipes,dipo,don,el,elding");
          demonic_name.motto_parts.Add("FO", "Fo");
          demonic_name.motto_parts.Add("FO2", "lco,nseca,rtunata,rtunato,lco,lvy,nseca,nsina,ntainha,ntana,ntelina,ntes,ntoura,rbek,rco,rd,rjaz,rmião,rmosindo,rrest,rster,rtes,rtuna,rtunat,rtunata,rtunato,rtunatus,rtuné,rtúnio,scoli,oster");
          demonic_name.motto_parts.Add("FlA", "Fla");
          demonic_name.motto_parts.Add("FlA2", "mínia,mínio,vio,via,co,mar,mba,mbê,meo,nar,nco,tos,uta,uto,nde");
          demonic_name.motto_parts.Add("FlO", "Flo");
          demonic_name.motto_parts.Add("FlO2", "ra,rária,rênça,rentina,riano,riana,riena,rinda,florindo,ripes,risberto,co,r,resta,ral,rista,rete,co,rescente,restal");
          demonic_name.motto_parts.Add("FRA", "Fra");
          demonic_name.motto_parts.Add("FRA2", "ncino,ncisco,nco,nklin,co,ngo,gil,lda,ção,nça,nja,nquia,nzino");
          demonic_name.motto_parts.Add("FRE", "Fre");
          demonic_name.motto_parts.Add("FRE2", "derico,te,sco,io,guês,nesim,ira,vo,i,mito");
          demonic_name.motto_parts.Add("FRI", "Fri");
          demonic_name.motto_parts.Add("FRI2", "tz,to,ta,o,a,r,tura,cção,eira,cativo,sante,volo,volidade,gido");
          demonic_name.motto_parts.Add("FRO", "Fro");
          demonic_name.motto_parts.Add("FRO2", "is,ta,nte,nha,ntal,nteira,uxo,ndoso,uxidão");
          demonic_name.motto_parts.Add("FRU", "Fru");
          demonic_name.motto_parts.Add("FRU2", "ta,to,ir,strante,strado,tívoro,tose,tado");
          demonic_name.motto_parts.Add("ALL", "Fe,Fi,Fo,Fla,Flo,Fra,Fre,Fri,Fro,Fru");
          demonic_name.motto_parts.Add("ALL2", "biana,biano,bio,brício,gundes,lcão,tima,usta,ustina,usto,uzi,aria,baino,ber,berly,bi,bia,bian,biande,biane,biani,biela,bien,bielle,bieli,biele,bline,brini,brinny,brisia,brizia,brizio,bron,byane,derico,lícia,liciana,lipe,lisbela,lisberto,lix,rdinando,rnandes,rnando,ron,fe,arnot,be,bo,dalto,dato,dele,don,dra,dro,dus,geuijó,io,ital,itosa,lênio,lia,lice,lícia,lician,liciana,liciano,licidade,lício,licis,licíssima,licíssimo,limina,lipa,lipe,pao,pinho,liphe,lippa,lippe,liquex,lisa,lisbela,del,delino,gueiredo,filadelfo,léas,lemon,lipe,lomena,rmina,rmino,ácria,ácrio,alho,amma,del,delia,delina,delino,délio,delir,delis,delius,dência,denciano,dêncio,diene,denzio,fides,dias,dipes,dipo,don,el,elding,lco,nseca,rtunata,rtunato,lco,lvy,nseca,nsina,ntainha,ntana,ntelina,ntes,ntoura,rbek,rco,rd,rjaz,rmião,rmosindo,rrest,rster,rtes,rtuna,rtunat,rtunata,rtunato,rtunatus,rtuné,rtúnio,scoli,oster,mínia,mínio,vio,via,co,mar,mba,mbê,meo,nar,nco,tos,uta,uto,nde,ra,rária,rênça,rentina,riano,riana,riena,rinda,florindo,ripes,risberto,co,r,resta,ral,rista,rete,co,rescente,restal,ncino,ncisco,nco,nklin,co,ngo,gil,lda,ção,nça,nja,nquia,nzino,tz,to,ta,o,a,r,tura,cção,eira,cativo,sante,volo,volidade,gido,is,ta,nte,nha,ntal,nteira,uxo,ndoso,uxidão,ta,to,ir,strante,strado,tívoro,tose,tado");
          demonic_name.motto_parts.Add("surname", "Fagundes,Faleiros,Falópio,Faria,Falqueto,Farias,Faro,Ferrão,Ferreira,Fernandes,Ferrolho,Figo,Figueira,Figueiredo,Figueiroa,Fioravante,Fonseca,Fontes,Fortaleza,França,Freitas,Furquim,Furtado,Feitosa,Flores");
          demonic_name.motto_parts.Add("TA", "Ta");
          demonic_name.motto_parts.Add("TA2", "bajara,batinga,bita,taciana,taciano,cio,cita,cito,deu,ís,lásio,lassa,léia,les,lia,lita,mar,mara,muz,ncredo,nia,rcísio,rcísia,rsila,sso,tiana,tiano,tuí");
          demonic_name.motto_parts.Add("TE", "Te");
          demonic_name.motto_parts.Add("TE2", "d,dio,obaldo,odolinda,odolindo,odomiro,odomira,odorico,odoro,odósia,odósio,ófanes,ofânia,ófila,ógenes,otônio,rcia,rcio,rêncio,rênsis,resa,rtuliano,seu");
          demonic_name.motto_parts.Add("TI", "Ti");
          demonic_name.motto_parts.Add("TI2", "ago,baji,bério,biriçá,búrcio,ciano,ciana,mon,móteo,na,noco,rreno,rso,to,ta");
          demonic_name.motto_parts.Add("TO", "To");
          demonic_name.motto_parts.Add("TO2", "bias,más,másia,mé,ni,pázio");
          demonic_name.motto_parts.Add("TRI", "Tri");
          demonic_name.motto_parts.Add("TRI2", "stão,ste");
          demonic_name.motto_parts.Add("TU", "Tu");
          demonic_name.motto_parts.Add("TU2", "rmalina,barão,rco,rbo,do");
          demonic_name.motto_parts.Add("ALL3", "Ta,Te,Ti,To,Tu,Tri");
          demonic_name.motto_parts.Add("ALL4", "ta,bajara,batinga,bita,taciana,taciano,cio,cita,cito,deu,ís,lásio,lassa,léia,les,lia,lita,mar,mara,muz,ncredo,nia,rcísio,rcísia,rsila,sso,tiana,tiano,tuí,d,dio,obaldo,odolinda,odolindo,odomiro,odomira,odorico,odoro,odósia,odósio,ófanes,ofânia,ófila,ógenes,otônio,rcia,rcio,rêncio,rênsis,resa,rtuliano,seu,rseu,ago,baji,bério,biriçá,búrcio,ciano,ciana,mon,móteo,na,noco,rreno,rso,to,ta,bias,más,másia,mé,ni,pázio,stão,ste,rmalina,barão,rco,rbo,do");
          demonic_name.motto_parts.Add("surname2", "Tavares,Teixeira,Tamburi,Tales,Teles,Toledo,Torquato,Trindade,Tunes,Thiago");
          demonic_name.motto_parts.Add("ALL5", "Fe,Fi,Fo,Fla,Flo,Fra,Fre,Fri,Fro,Fru,Ta,Te,Ti,To,Tu,Tri");
          demonic_name.motto_parts.Add("ALL6", "biana,biano,bio,brício,gundes,lcão,tima,usta,ustina,usto,uzi,aria,baino,ber,berly,bi,bia,bian,biande,biane,biani,biela,bien,bielle,bieli,biele,bline,brini,brinny,brisia,brizia,brizio,bron,byane,derico,lícia,liciana,lipe,lisbela,lisberto,lix,rdinando,rnandes,rnando,ron,fe,arnot,be,bo,dalto,dato,dele,don,dra,dro,dus,geuijó,io,ital,itosa,lênio,lia,lice,lícia,lician,liciana,liciano,licidade,lício,licis,licíssima,licíssimo,limina,lipa,lipe,pao,pinho,liphe,lippa,lippe,liquex,lisa,lisbela,del,delino,gueiredo,filadelfo,léas,lemon,lipe,lomena,rmina,rmino,ácria,ácrio,alho,amma,del,delia,delina,delino,délio,delir,delis,delius,dência,denciano,dêncio,diene,denzio,fides,dias,dipes,dipo,don,el,elding,lco,nseca,rtunata,rtunato,lco,lvy,nseca,nsina,ntainha,ntana,ntelina,ntes,ntoura,rbek,rco,rd,rjaz,rmião,rmosindo,rrest,rster,rtes,rtuna,rtunat,rtunata,rtunato,rtunatus,rtuné,rtúnio,scoli,oster,mínia,mínio,vio,via,co,mar,mba,mbê,meo,nar,nco,tos,uta,uto,nde,ra,rária,rênça,rentina,riano,riana,riena,rinda,florindo,ripes,risberto,co,r,resta,ral,rista,rete,co,rescente,restal,ncino,ncisco,nco,nklin,co,ngo,gil,lda,ção,nça,nja,nquia,nzino,tz,to,ta,o,a,r,tura,cção,eira,cativo,sante,volo,volidade,gido,is,ta,nte,nha,ntal,nteira,uxo,ndoso,uxidão,ta,to,ir,strante,strado,tívoro,tose,tado,ta,bajara,batinga,bita,taciana,taciano,cio,cita,cito,deu,ís,lásio,lassa,léia,les,lia,lita,mar,mara,muz,ncredo,nia,rcísio,rcísia,rsila,sso,tiana,tiano,tuí,d,dio,obaldo,odolinda,odolindo,odomiro,odomira,odorico,odoro,odósia,odósio,ófanes,ofânia,ófila,ógenes,otônio,rcia,rcio,rêncio,rênsis,resa,rtuliano,seu,rseu,ago,baji,bério,biriçá,búrcio,ciano,ciana,mon,móteo,na,noco,rreno,rso,to,ta,bias,más,másia,mé,ni,pázio,stão,ste,rmalina,barão,rco,rbo,do");
          demonic_name.motto_parts.Add("ALL7", "Fagundes,Faleiros,Falópio,Faria,Falqueto,Farias,Faro,Ferrão,Ferreira,Fernandes,Ferrolho,Figo,Figueira,Figueiredo,Figueiroa,Fioravante,Fonseca,Fontes,Fortaleza,França,Freitas,Furquim,Furtado,Feitosa,Flores,Tavares,Teixeira,Tamburi,Tales,Teles,Toledo,Torquato,Trindade,Tunes,Thiago");
          demonic_name.motto_parts.Add("space", " ");
          demonic_name.templates.Add("FLO,FLO2");
          demonic_name.templates.Add("FA,FA2,space,surname");
          demonic_name.templates.Add("FE,FE2,space,surname");
          demonic_name.templates.Add("FI,FI2,space,surname");
          demonic_name.templates.Add("FO,FO2,space,surname");
          demonic_name.templates.Add("FLA,FLA2,space,surname");
          demonic_name.templates.Add("FLO,FLO2,space,surname");
          demonic_name.templates.Add("FRA,FRA2,space,surname");
          demonic_name.templates.Add("FRE,FRE2,space,surname");
          demonic_name.templates.Add("FRI,FRI2,space,surname");
          demonic_name.templates.Add("FRO,FRO2,space,surname");
          demonic_name.templates.Add("FRU,FRU2,space,surname");
          demonic_name.templates.Add("FLO,FLO2,space,surname");
          demonic_name.templates.Add("ALL,ALL2");
          demonic_name.templates.Add("ALL,ALL2,space,surname");
          demonic_name.templates.Add("TA,TA2");
          demonic_name.templates.Add("TE,TE2");
          demonic_name.templates.Add("TI,TI2");
          demonic_name.templates.Add("TO,TO2"); 
          demonic_name.templates.Add("TU,TU2");
          demonic_name.templates.Add("TRI,TRI2");
          demonic_name.templates.Add("TA,TA2,space,surname2");
          demonic_name.templates.Add("TE,TE2,space,surname2");
          demonic_name.templates.Add("TI,TI2,space,surname2");
          demonic_name.templates.Add("TO,TO2,space,surname2");
          demonic_name.templates.Add("TU,TU2,space,surname2");
          demonic_name.templates.Add("TRI,TRI2,space,surname2");
          demonic_name.templates.Add("ALL3,ALL4");
          demonic_name.templates.Add("ALL3,ALL4,space,surname");
          demonic_name.templates.Add("ALL5,ALL6");
          demonic_name.templates.Add("ALL5,ALL6,space,ALL7");
          AssetManager.nameGenerator.add(demonic_name);

          //Extras

          NameGeneratorAsset trollsName = new NameGeneratorAsset();
          trollsName.id = "trolls_name";
          trollsName.part_groups.Add("Gradrik,Prirrid,Zedder,Ren,Brad,Chur,Didd,Glur,Prod,Razin,Ran,Trirk,Trarir,Dekt,Brazkar,Chegt,Gatt,Sreg,Ek,Gloffig");
          trollsName.templates.Add("part_group");
          AssetManager.nameGenerator.add(trollsName);

          NameGeneratorAsset griffinsName = new NameGeneratorAsset();
          griffinsName.id = "griffins_name";
          griffinsName.part_groups.Add("Tyr,Tiw,Tyg,Brightwatcher,Fraytalon,Feyclaw,Mannion,Tiernan,Goldcrest,Dreamfeather,Windchase,Whiteclaw,Whiteclaw,Bronzefeather,Stagbuck,Shadowbeak,Stagbuck,Stagbuck,Twilightdive,Brien,Keenan,Bluechaser,Fraybuck,Leybill,Sharpflight,Netherbill,Lightfall,Flynn,Hurley");
          griffinsName.templates.Add("part_group");
          AssetManager.nameGenerator.add(griffinsName);

          NameGeneratorAsset darkknightName = new NameGeneratorAsset();
          darkknightName.id = "darkknight_name";
          darkknightName.part_groups.Add("Itzzz,Jamyhect,Navaleo,Hanaut,Vereroll,Jamyfred,Gilgala,Hangere,Rahad,Reinacco,Tybval,Ericoacco,Leoael,Berhect,Neval,Martbarte,Grenantjord,Nulfor,Nulfles,Tusmik,Tybgar,Kargere,Tusgau,Partus,Monarnold");
          darkknightName.templates.Add("part_group");
          AssetManager.nameGenerator.add(darkknightName);

          NameGeneratorAsset phoenixName = new NameGeneratorAsset();
          phoenixName.id = "phoenix_name";
          phoenixName.part_groups.Add("Fyre,Plume,Ignite,Solaris,Spirit,Slag,Ryze,Solar,Brilliancy,Onyx,Nix,Soleil,Viva,Scorchey,Flametalon,Pharos,Brilliancy,Sun,Pire,Aura,Deja,Sunny");
          phoenixName.templates.Add("part_group");
          AssetManager.nameGenerator.add(phoenixName);

          NameGeneratorAsset witchName = new NameGeneratorAsset();
          witchName.id = "witch_name";
          witchName.part_groups.Add("Frances Wraith,Saffron Shadowsoul,Sabrina Roseberg,Sabrina Roseberg,Glinda Vigil,Myrna Evilian,Agnes Trevils,Luciana Shadowend,Valkyrie Villalobos,Selena Drach,Kira Soulton,Gillian Tempest,Daire Krauss,Aggie Manglyeong,Rowena Barlow,Tabitha Void,Sally Fade,Sally Fade,Simone Riddle,Orchid Void");
          witchName.templates.Add("part_group");
          AssetManager.nameGenerator.add(witchName);

          NameGeneratorAsset GodzillaName = new NameGeneratorAsset();
          GodzillaName.id = "Godzilla_name";
          GodzillaName.part_groups.Add("Godzilla");
          GodzillaName.templates.Add("part_group");
          AssetManager.nameGenerator.add(GodzillaName);

          NameGeneratorAsset dragonslayerName = new NameGeneratorAsset();
          dragonslayerName.id = "dragonslayer_name";
          dragonslayerName.part_groups.Add("Ky");
          dragonslayerName.templates.Add("part_group");
          AssetManager.nameGenerator.add(dragonslayerName);
		}
	}
}