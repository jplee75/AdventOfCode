using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DotOne();
            DotTwo();
        }

        static void DotOne()
        {
            List<List<String>> puzzleInput = PuzzleInput.GetInput();
            int goodPhrases = 0;

            foreach (List<String> passPhrase in puzzleInput)
            {
                if (passPhrase.Distinct().Count() == passPhrase.Count())
                {
                    goodPhrases += 1;
                }
            }

            Console.WriteLine(goodPhrases);
            Console.ReadKey();
        }

        static void DotTwo()
        {
            List<List<String>> puzzleInput = PuzzleInput.GetInput();
            int goodPhrases = 0;

            foreach (List<String> passPhrase in puzzleInput)
            {
                List<String> sortedPhrases = new List<string>();

                foreach (String phrase in passPhrase)
                {
                    String newPhrase = String.Concat(phrase.OrderBy(c => c));
                    sortedPhrases.Add(newPhrase);
                }

                if (sortedPhrases.Distinct().Count() == passPhrase.Count())
                {
                    goodPhrases += 1;
                }
            }

            Console.WriteLine(goodPhrases);
            Console.ReadKey();
        }
    }
    class PuzzleInput
    {
        public static List<List<String>> GetInput()
        {
                return new List<List<String>>()
                {
                    new List<string>(){"sayndz","zfxlkl","attjtww","cti","sokkmty","brx","fhh","suelqbp"}
                    ,new List<string>(){"xmuf","znkhaes","pggrlp","zia","znkhaes","znkhaes"}
                    ,new List<string>(){"nti","rxr","bogebb","zdwrin"}
                    ,new List<string>(){"sryookh","unrudn","zrkz","jxhrdo","gctlyz"}
                    ,new List<string>(){"bssqn","wbmdc","rigc","zketu","ketichh","enkixg","bmdwc","stnsdf","jnz","mqovwg","ixgken"}
                    ,new List<string>(){"flawt","cpott","xth","ucwgg","xce","jcubx","wvl","qsysa","nlg"}
                    ,new List<string>(){"qovcqn","zxcz","vojsno","nqoqvc","hnf","gqewlkd","uevax","vuna","fxjkbll","vfge"}
                    ,new List<string>(){"qrzf","phwuf","ligf","xgen","vkig","elptd","njdm","gvqiu","epfzsvk","urbltg","dqg"}
                    ,new List<string>(){"sfpku","viwihi","fje","umdkwvi","ejzhzj","qrbl","sfpku","sad","nawnow","ksnku"}
                    ,new List<string>(){"nzhj","mfudick","ueaa","jnhz","kpy","pzk"}
                    ,new List<string>(){"euiin","xvl","elaoelu","wbdd","xlv","jtm","nohtq","gfdbgdg","gdfggdb","edtym"}
                    ,new List<string>(){"xfmkn","wyww","woe","hwysuh","gjw","dtk","utryasc","dela","eluk","vmmun"}
                    ,new List<string>(){"nmag","qfwe","cwslmgd","nlhf","hpf"}
                    ,new List<string>(){"ifs","sszo","iod","isf","jna"}
                    ,new List<string>(){"pjptwg","wreera","leyb","hmlbpf","qcrbma","ylgue"}
                    ,new List<string>(){"rwlpo","jhla","rprxvgs","quguh","pyybwgl","qqvcb"}
                    ,new List<string>(){"rxtcpdy","wmpci","mpcwi","vwvdzdn","nfpnj","rcsxinl","itatg","ycy","hrctg","ron","wveju"}
                    ,new List<string>(){"zmkfn","wip","pyiz","pyiz","tnyg","dvftf","elks","ezhotbj","wip"}
                    ,new List<string>(){"sgmtfdd","xdl","sch","sch","yaxzh","wphgksh","knzrixp","yaxzh","etm","czqbaa","jldta"}
                    ,new List<string>(){"gnbr","rnpd","upe","eeb","sbq","sbq","oxc","rwvugoj"}
                    ,new List<string>(){"cshk","thcc","emfxx","emfxx","pbtcf","jpim","vltkqar","czy","iudkac","jhpcc","nqs"}
                    ,new List<string>(){"uzbvx","fkiuyk","izxdiu","yutntvn","dixuzi","hkyfnud","oyz","ynutntv"}
                    ,new List<string>(){"ewl","mfns","idy","fphu","yqccb","pte","unukirt","unukirt","fdx"}
                    ,new List<string>(){"lzn","tin","fgena","qbql","qycbdw","gbtn","lctlysx","adhjfq","blu","aiv"}
                    ,new List<string>(){"ites","ites","pbxzunl","vljzh","lqgerta","pbxzunl"}
                    ,new List<string>(){"vmk","wjfzvhn","pqkidze","qfwh"}
                    ,new List<string>(){"tqprmc","exypl","caf","kwikh","mdyyljc","pbo","hhxxo","skna"}
                    ,new List<string>(){"sqxgejb","ejc","fvup","hpesvs","luz","fcxqwhr","ypxof","fxlcp","pxyk","xiczjri"}
                    ,new List<string>(){"vjg","qcw","fsyqaoj","mxf","jha","feclqqr","vzdqnk","verw","mvmvm","pvdqtcd","xsfu"}
                    ,new List<string>(){"fwwn","ktvdh","aecfv","acfve","yjozxwo","cnujw","bcgde","lphnk","knlph","bqwlqju"}
                    ,new List<string>(){"uwwapm","dlln","uwwapm","uwwapm"}
                    ,new List<string>(){"huupab","ewetcte","huupab","ewetcte"}
                    ,new List<string>(){"wjs","zipivpd","klwafr","ipcczg","wbv","uujstsw","hykn"}
                    ,new List<string>(){"mgojdyh","hlm","xruta","lbmaxit","pabqrnp","vkyigd","ptpzr","glin","gfau","pbo"}
                    ,new List<string>(){"tbwx","baqxq","vtz","jwex","tvz","tzv"}
                    ,new List<string>(){"efopwx","wfknzb","ogaxln","tqzrh","jne","zugd","zpxikma"}
                    ,new List<string>(){"rdjsa","arjds","hqdldw","fjrtl","midt","qjv","jfrlt"}
                    ,new List<string>(){"dggqohj","bidaaty","iah","lgmug","wwmlbc","lggmu","laonaoq","erkqrb","tqolnns","iygv","qnonlst"}
                    ,new List<string>(){"msc","glwn","xjfnij","itt","pka","irrafjd","euazydj","silo"}
                    ,new List<string>(){"zsyut","znsht","ldky","zsyut","dzcdft","znsht"}
                    ,new List<string>(){"iit","cyteu","pib","fgvrs","iux","ffctql","pib","zuzp","zsbb","ieoi"}
                    ,new List<string>(){"xxtwlu","kqfxjhq","isj","xqjhfkq","dohrs","haovzc","cgfwfrt","munqon","vuyexz","nouqnm"}
                    ,new List<string>(){"eptpqgi","uiflvd","acj","livzq","ejtt","bniud","cjdh","jkrcken","lspfy","tpxri","zibj"}
                    ,new List<string>(){"zxme","dpo","fumup","gly","bkdcwxn","lsly","eglhe"}
                    ,new List<string>(){"uoshw","ijoyiql","rcskaa","vjbqv","roiinzi","fppqdu"}
                    ,new List<string>(){"xuw","vdbxie","oypcx","khxq","xebjt","oypcx","uitqep","vdbxie","hoz"}
                    ,new List<string>(){"lrjv","tdksk","uebo","wktebvx","nlapmp","udhhxh","uliqbm","cklyyf","jlzw","xrmdlvx"}
                    ,new List<string>(){"fosspck","fosspck","fosspck","qyidyur","hxnxmb","dkpj"}
                    ,new List<string>(){"rmrvlms","susvos","idw","hzy","idw","tjgxbc","lhgqxr","tjgxbc","uuq"}
                    ,new List<string>(){"etjmbdr","hwqe","lnfwzni","lnfwzni","good","eisci","etjmbdr"}
                    ,new List<string>(){"yqde","bmlcc","yuel","vpyplss","vyvhho","kslgiu","lllhc","jtkijdj","uclz","hfbqsf"}
                    ,new List<string>(){"tlohlvv","tlohlvv","bdqahw","tlohlvv","qavcqrn","penia","saafy"}
                    ,new List<string>(){"lvtzyt","qffe","eaikhv","eaikhv","wbnl","mdkg","mdkg","utfrm"}
                    ,new List<string>(){"luowwk","magp","luowwk","oyao","oyao","hsb","yms"}
                    ,new List<string>(){"gnxply","vsdqum","nprf","jik","axdp","ariqjpc","hjqcc"}
                    ,new List<string>(){"izbo","nkqkb","xpqg","pgxq","qpxg","gpm","jxbkvu","resj"}
                    ,new List<string>(){"hsgyxar","hvsl","ner","zzmcn","lcpdvqn","ern"}
                    ,new List<string>(){"rfjlhu","xkyh","hafs","cvvk","drg","vjsk","mymc","iab","ycmlubx","kpwemiw"}
                    ,new List<string>(){"wlci","qhhpr","vhpr","oyrili","cnynh","sivdso","ldjya","wilc","ioiyrl"}
                    ,new List<string>(){"cdfwd","mbtk","sienxui","jsmxzo","yxbeyl","bybtc","covxaq","yuxn","ktbvztl","ktbvztl","rcekjhk"}
                    ,new List<string>(){"ptenhqv","tzdt","phetqvn","mfkdz"}
                    ,new List<string>(){"hmezeak","pqvqld","amsih","jxqacc","uferfyh","nfqjsz","rtuqdzz","pohcx","qia","cpxho","hgpqs"}
                    ,new List<string>(){"iygny","dluc","uxqz","nlujm","xkdtlm","xbdgepg","jwn","ohl","wpfll"}
                    ,new List<string>(){"lnqf","pcxy","cpit","enp","zpj","lqfn","oowgw","yoxdff","ohvcfcf","fuvz","qkpmb"}
                    ,new List<string>(){"oydu","jlscilm","pzxen","nmtdngu","tslcupx","ntdgmun","uztpx","nlhh","jqn","llsv"}
                    ,new List<string>(){"euyx","epn","gyvg","cwtoe","ruyap","yaurp","uryap","obbl","ovo"}
                    ,new List<string>(){"pgo","irm","ksrxe","qotuygd","afwh","qfhzfsr","wafh","dqjbwce","dzfo","hew","skrxe"}
                    ,new List<string>(){"dpvel","dpvel","ipljjxs","vrrsob","iakey","uheuu","swxu","qmnmn","mpjkb","jqrwfmv","jozj"}
                    ,new List<string>(){"sempz","plzxqe","qvyg","sempz","fejux"}
                    ,new List<string>(){"cqgqvg","zhqir","rqzih","vyu","fmb","mfb"}
                    ,new List<string>(){"uejl","kjh","ayz","dzimg","yzafvg","dem","vlogg"}
                    ,new List<string>(){"htfkd","htfkd","hwykmm","htfkd"}
                    ,new List<string>(){"oxvgq","wtai","rkyyxya","ldkecdv"}
                    ,new List<string>(){"lvlrsu","rsullv","pptnrwi","slvulr","vxrk","dpzti"}
                    ,new List<string>(){"gde","ixwoz","nnsx","nhc","nzi"}
                    ,new List<string>(){"dsadkj","qtgya","wco","psyondq","jayad","crc","lswwm","purrad","pof"}
                    ,new List<string>(){"nocibgs","hxqdejv","nlqxdpu","dvzd"}
                    ,new List<string>(){"jfaws","aiwnjm","tqjpgs","fuiobz","gwnemv","hjevs","xkbbgiq","sakgv","zmwpkuq","grjllw"}
                    ,new List<string>(){"xrr","jwhtchs","boaqkg","wjhdr","xrr"}
                    ,new List<string>(){"vyapct","tgw","juzgwkz","odddvof","juzgwkz"}
                    ,new List<string>(){"unuu","kubdd","dxr","drwg"}
                    ,new List<string>(){"qpefzz","iemo","fwa","vhdcxx"}
                    ,new List<string>(){"hseqy","copss","gytzub","lxi","mrxtwc","hxqqdfx","ijt","kcy","tafjs","jit"}
                    ,new List<string>(){"uevse","rrq","zmwyjfe","xljx","lhgnyzt","rngvwqd"}
                    ,new List<string>(){"gfvpyhq","xpdhind","eocgpiz","ebs","pcmsgjy","swni","iwns","thspnh","yvbzxz","fgb"}
                    ,new List<string>(){"hxr","ehw","ekfd","ncxcs","gxjmd","oqszdjp","fgu","gwuoafw","zumenf","qltbw","whzuxov"}
                    ,new List<string>(){"wfc","pawqo","pim","jxgt","dtiwzil","hdptivc","slkazm","htafjih","hzheez","rkk","amy"}
                    ,new List<string>(){"mgoatiy","pkec","ddvwyni","zuya","aqrcjes","ubkaeus","nuhhad","upe","qfem","bpcc"}
                    ,new List<string>(){"rmyeg","qfq","bia","lzk","fusqfb","ltvgry","vggr","xaxi","avwdkbg","zhlzt"}
                    ,new List<string>(){"zkjoeee","dyi","sxdwfqa","irqljmw","gek","dgdb","mrakr","ddaznn","zlh","ajzzacf","juv"}
                    ,new List<string>(){"kmqcy","pohbej","hujdgao","rsxfkn","vlu"}
                    ,new List<string>(){"scnpa","hvl","cybql","lvh","lbcyq","msw","deqqb","yjpsndq"}
                    ,new List<string>(){"ndhjooo","dpf","ziey","jtjlc","eesag","ldhgoif"}
                    ,new List<string>(){"tysbae","wkpst","kjz","stpkw","sil","yetsba"}
                    ,new List<string>(){"ghvlfq","flhvgq","tgkjie","gqlvfh"}
                    ,new List<string>(){"oimn","vlmsljl","ocala","vokhrs","odyv","msn","dzly","wcky"}
                    ,new List<string>(){"cfjwmh","rpsdor","bttnkg","jxenm","mwdk","mer","jgsusdz","cslf"}
                    ,new List<string>(){"ialvxk","bvc","qjfikr","caw","puhmmfl","xpmsx"}
                    ,new List<string>(){"tyoey","egcf","dijg","vywd","enued","uxkshz","nav","bdrn","hjugffi","iobqwiy"}
                    ,new List<string>(){"eykhxck","shpfjhk","vlqg","alkenz","kuj","okxs","oeth","mqbr","nfvqvkv","xfvyi","mboo"}
                    ,new List<string>(){"zbw","curcajm","mel","jxqcw","mpdscxq","rhadty","zrddeh","wmedc","wkcwt","yvwm"}
                    ,new List<string>(){"iee","hzeofmh","pqlkkb","azlam","fpj","hzeofmh","ripi"}
                    ,new List<string>(){"sawaqek","oyoiwtb","npq","pisadk","nnd","bzgo","wiqme","lxnvn"}
                    ,new List<string>(){"obqx","ffiegn","obxq","for","xobq"}
                    ,new List<string>(){"zwway","wwazy","aqxg","gaxq"}
                    ,new List<string>(){"ebssilw","nuscati","mofyc","sogyacc","yujmdwu","ehxsx","qcaf","udvoo","nlcfaz","eov"}
                    ,new List<string>(){"vnbe","wtzzjn","bczyxt","crmvas","zujy","kukq","zujy","kukq"}
                    ,new List<string>(){"gvltk","kgltv","kglvt","zflikic"}
                    ,new List<string>(){"hby","pium","gut","fjqn","sksoqyq","kcliapa"}
                    ,new List<string>(){"tbonrr","prf","vga","jqgw","ulze","ukfig"}
                    ,new List<string>(){"zafixw","hia","omgwoi","noeiox","fqbket","iviidgp","bebune","kwcuotp","slvy","wcx"}
                    ,new List<string>(){"fjq","cyecn","fhxvj","byv","kojvj","iaqd","aaxva","rkogp"}
                    ,new List<string>(){"vqbbt","sjmr","mxu","mxu","rlfj","yqhtzv","cuar","yde","yrs","sjmr"}
                    ,new List<string>(){"iyxiyp","auepgw","dtpbyvu","thuoai","fpsfkpn","bemgbsk","lni","ozy","jogp","xldyvvx","fpsfkpn"}
                    ,new List<string>(){"jtha","ibn","ahbkh","xzxkei","tql","mycvmyh","ioyw"}
                    ,new List<string>(){"mpsc","pvdiuu","wqixxlo","cqwmlrw","cttoz","lad"}
                    ,new List<string>(){"srl","xxlnofu","dqf","snxd","zjlp","htxzd"}
                    ,new List<string>(){"fkv","berlbyh","kyna","wkme","qjzgh","thpw","frup"}
                    ,new List<string>(){"irhreaj","udkpbza","qmgp","ormlipa","lbyuc"}
                    ,new List<string>(){"empizc","apcb","ossmtj","awk","ttsgi","bfoymzd","ftx","jkicph","qqjv","tywp","fwzfe"}
                    ,new List<string>(){"zaqkd","ysn","zaluvs","rljdk","ast","fjp","amjqr","uabrya","ufswzjg","vcldkxt","hzsmrbl"}
                    ,new List<string>(){"qvy","tqgnwj","akibr","tfjevhv","vav"}
                    ,new List<string>(){"mhe","sxg","hacoa","emh","kasf","hid","jklfy","ijk","dih"}
                    ,new List<string>(){"qvwbenk","akdctm","jztmsx","aqvpodu","vmknns","nck","letcrk","poba"}
                    ,new List<string>(){"lhve","kkvff","iiixid","vtsun","uvgte","mmlxk","pgd"}
                    ,new List<string>(){"gktphd","aaoqwz","lrvsuw","ofcyvmi","suvwrl","dpqiol","wjgj","uqigjx"}
                    ,new List<string>(){"tbp","xoc","lmz","dyzlvp","bjleh","pxj","xjp","xbil"}
                    ,new List<string>(){"gpzgvj","tctszm","tctszm","pnp","upqtmm","rribg","tctszm","sllsbr"}
                    ,new List<string>(){"hpm","qvjnd","lyqg","bybpwn","etz","pwfigbg","uqgrvpg","cvniubo"}
                    ,new List<string>(){"tpowus","bdncyxg","gmm","ebfg","zwoue","izgkwtx","gmtfeg","xvudp","xgmjp","atrvn","aqgl"}
                    ,new List<string>(){"wlrxvo","wvonohi","owxlvr","owhnvoi"}
                    ,new List<string>(){"knyo","aiixyi","sjtqb","kukhgv","qkj","qiuefb","syhfc","aoana","okmot","tdsmnoj","eyzqjn"}
                    ,new List<string>(){"szhto","szhto","szhto","fxpsavu","dtcz","hnwqdvk","iza"}
                    ,new List<string>(){"poykme","rboczge","tuyiw","sxr"}
                    ,new List<string>(){"lpgbp","bpmf","aiqy","exzqt","gxdoow","yjp","fxwdmt","eoklc","jnps","zbnbiwr","ppvl"}
                    ,new List<string>(){"huecy","jjhyz","pwcea","ffofmj","tts"}
                    ,new List<string>(){"ahbmkw","brz","xdenmw","mwexnd","ncdxgf","gcxnfd"}
                    ,new List<string>(){"yhfnra","vqljz","bkyxzt","vhtsyde","ysaxt","qbw"}
                    ,new List<string>(){"gqhiej","rofhmp","soeebdp","rcuiblb","rcuiblb","rrnh","nses"}
                    ,new List<string>(){"pxrwe","suil","iihzf","lhcgmfm","mqasxh","ttpp","kqitdyf","cuabaa"}
                    ,new List<string>(){"cxl","cwsp","qyseogj","dimvv","igsoxu","ncrexla","ubrvpp","oum","usluv"}
                    ,new List<string>(){"rkmo","jqqcdjb","mobqcta","pbcmoi","afjlh","mork"}
                    ,new List<string>(){"nmohoeq","fezpxh","fezpxh","yec"}
                    ,new List<string>(){"yxlncrt","ivi","dajo","tjpim","tjpim"}
                    ,new List<string>(){"hzhy","rcjs","uhyvwz","tdpxlqw","itoiyf"}
                    ,new List<string>(){"ded","apfmhe","stfk","ugyujv","drwks","zagqnw","mbbzmvc","aoupemq"}
                    ,new List<string>(){"iezre","wivdwif","xzytxe","xwytd","vpnol","pljx","aot","phln","ztncw"}
                    ,new List<string>(){"ozblu","asda","tkxh","xqe","pvijnl","qwwh","uvp","bdhtgjt","uynwtav","cdz","uqmvp"}
                    ,new List<string>(){"eukgtsy","kdfb","bdfk","tnv","dfkb","ewdemb"}
                    ,new List<string>(){"rsf","cxnk","cid","qsa","zwk","oetnggn"}
                    ,new List<string>(){"fpq","oim","zetbmlk","fpq","oim","xgv","cbaj","cjrqm"}
                    ,new List<string>(){"phgldt","fhmkc","efkztj","qidri","vsv","bvjf","lfwfgm","wfuoln","toamg","wfuoln","idrs"}
                    ,new List<string>(){"iuc","rrdnk","rrdnk","asqhnz","qxkigmo","eeoim","mmdtgif","akk"}
                    ,new List<string>(){"rfvsyy","kopfhmd","tnv","ibo","demeqm","gxrxw","hwk","ukorln","bep"}
                    ,new List<string>(){"ialo","eogif","sxlj","xfegx","nanch","egoif","eymwt"}
                    ,new List<string>(){"kttrpjq","gbnyiat","kptg","oarewx","vkmt","gbnyiat","szyokf"}
                    ,new List<string>(){"tjll","xviodi","tjll","efc","rliugl","wfbbpq","wsqvdli","jur","tjll","bguqyu"}
                    ,new List<string>(){"uecm","yzjhn","vqf","labnc","xyaksj"}
                    ,new List<string>(){"hjtef","zzq","ellr","wtrodcg","drwqo","ernt","uzx","sqiokam"}
                    ,new List<string>(){"izmh","ddutl","bdzft","jvfthh"}
                    ,new List<string>(){"ecr","xqrp","qlxstu","kgprd","gqvtwni","mkughf","bulabe","bvoxkx"}
                    ,new List<string>(){"jwsna","vjwq","swkycg","cpp","dvmyal","xotxviy","qkiva","ffa","eakwp","fww","yirri"}
                    ,new List<string>(){"ufnl","lpuxw","rjki","nggh","ajdkpvo","oeuaemy","bjisma","vsjzc"}
                    ,new List<string>(){"ctxu","aavlw","rap","fzxtcp","msufn","fzxtcp","sdlaom","vgvdvpc"}
                    ,new List<string>(){"rftw","cyf","twyxi","orifavd"}
                    ,new List<string>(){"ogiht","ertz","wcw","jnqdup","phvp","lbw"}
                    ,new List<string>(){"tplpyq","jeh","aobamqe","bvaim","qptac","gssi","mkjbaj"}
                    ,new List<string>(){"nmklyg","iitx","iczojzr","vjspqb","uooky","uooky","hjk"}
                    ,new List<string>(){"ggnekbb","bnebggk","sepzjd","fvqfgr"}
                    ,new List<string>(){"wnfwrn","yaiogv","mbusuy","cpbcgs","thjea"}
                    ,new List<string>(){"atndjc","dbjgdz","guedeay","rasa","kfhame","pusuu","dbjgdz"}
                    ,new List<string>(){"xivzyml","xivzyml","eqsykxo","bshvz","xivzyml"}
                    ,new List<string>(){"nfe","ayx","gscy","ylyp","oqyl","isatnpx","poaelm","zsrw","dpd","eyrdjpq","yllk"}
                    ,new List<string>(){"feqktz","mlm","jhi","yxigeu","xzqa","qwv","yquxw","emken","jgqsp","rojfcu"}
                    ,new List<string>(){"ruvfcud","poubal","xswer","hfhpyp","guf","pzgzoq","pzgzoq","jwgxafi","guf","kqzzlu","apg"}
                    ,new List<string>(){"rxwcsdc","rxwcsdc","ywu","rxwcsdc"}
                    ,new List<string>(){"dmgsey","xrtx","wldwyxz","avi"}
                    ,new List<string>(){"yxnqv","ewlx","fvif","ozfcbxb","zqapa","yudqksk","wlxe","mjpvgz"}
                    ,new List<string>(){"ozoa","ozoa","hwkbp","ozoa"}
                    ,new List<string>(){"qcv","drtqn","uqv","kcsavgn","ybzs","tkw"}
                    ,new List<string>(){"njmloq","wapa","srm","srm","ifurca"}
                    ,new List<string>(){"ezm","ccj","rub","yuaww","xhee","liikjee","kcabgic","sbgqx","vrpyo","pzmesdp","ksvv"}
                    ,new List<string>(){"hycyne","raaksm","nylsc","lcpgn","akasrm","vxwoaum"}
                    ,new List<string>(){"zhugs","pqquitv","bae","lyozb","fhij","pcdcc","bae","rygsgm","pqquitv","pizz"}
                    ,new List<string>(){"oxx","bzk","grpis","qiqljwh","svkn"}
                    ,new List<string>(){"qcq","qqc","fzgn","sqg"}
                    ,new List<string>(){"lclad","motw","ukz","zghp"}
                    ,new List<string>(){"glr","okzfs","zgv","ygsvv","sauuog","glr","amxr","vvmwmu","khy","eyh"}
                    ,new List<string>(){"ukpxpy","rgnqyaw","ncm","coeblf"}
                    ,new List<string>(){"qdbr","ortzo","spvnrnq","uomtj","vffbeva"}
                    ,new List<string>(){"miwar","bidfxp","eibo","qyee"}
                    ,new List<string>(){"yldec","ghwj","mxlemvi","imac","klkvmg","fekxhp","kevlzfr","fcgnoq","fncgqo"}
                    ,new List<string>(){"hlm","vlol","qdic","rltij","nlzxfys","rzpoh"}
                    ,new List<string>(){"krpwspb","yrosr","hioqla","dbpgzgu","dvkvvc","vvdckv","lcjzb","qbsbr","acbi","rtnk"}
                    ,new List<string>(){"iqtvk","jcldzuv","smly","whmnte","mdwlse","mkxw","mfnkv","mkxw","kes","owkfh"}
                    ,new List<string>(){"iwcjmkt","rnb","bjcdjl","furhzuu","exs"}
                    ,new List<string>(){"kjwu","iuaj","ixkujoa","jzeau","whpn"}
                    ,new List<string>(){"tvj","zrdy","fwsbagh","zrdy","czuzum","lxotprx","wbohaai"}
                    ,new List<string>(){"crsyzod","jouf","osxntw","iwzzie","bodu","scze","gjxn","vgxvqo","gjxn","mmthykb"}
                    ,new List<string>(){"dabjfb","vjqz","cvr","gsymwoe","qzpusj","twvwhw","gyvlqd","kdrdkzm","bdljp","cvr"}
                    ,new List<string>(){"vmswdz","lgjsvxz","yjkgqkg","tzmjkfp","uzbmwxe","kuqa","dzomt","hep","jjlibs","oxvpvq","cix"}
                    ,new List<string>(){"iqgd","btwdjd","ncdrovj","ltxqc","orwhdlo","orwhdlo"}
                    ,new List<string>(){"nxro","uxj","ovgha","elvzl","xmlzssr","wonimvb","urecfx","dbfn","kope"}
                    ,new List<string>(){"tbes","cgyh","fypswue","fgxjqtd","dxdrfm","pzhnaeu","kugspa"}
                    ,new List<string>(){"eouzw","qrpokyb","fyhpb","bcvfvze","brdwey","gpaa","fpqutw","pbqkroy","axtc","egamku","gxk"}
                    ,new List<string>(){"xdrovpt","peeww","wkcin","suir","gvrbix"}
                    ,new List<string>(){"hgsjks","juvod","jtii","iijt"}
                    ,new List<string>(){"yaw","hzifa","wpagkd","tgvmc","iru","yyeuy","mgcvt","fhiza"}
                    ,new List<string>(){"lsk","lks","kls","edypaxo"}
                    ,new List<string>(){"tjz","qjs","mgoyd","gomyd","ztjbex","nprwk","vvw","rtjsq","quvf","vuziqtb","oygdm"}
                    ,new List<string>(){"kftodz","xua","lyxt","zfadf","fgdwt","zfadf","xua","ehwykd","wniahd","mqoarg"}
                    ,new List<string>(){"qgiapb","xptk","iscyf","zfspn","qvrpva","egufqte","zfspn","hksw","xwxrs","dkdruku","vegfs"}
                    ,new List<string>(){"wqifs","wfsevg","iwnjjpi","oajju","tkvhpl","lemuw"}
                    ,new List<string>(){"rzbmhso","pbvb","lfgpq","fzjwxxh","pqlgf","rbhsomz"}
                    ,new List<string>(){"ufi","aiyd","gxozgx","hygjp","dtma","uughdc","ojumcf","yuadt"}
                    ,new List<string>(){"caami","tqzkvor","tqzkvor","tqzkvor"}
                    ,new List<string>(){"vhtnvyx","myxdywi","mwpwq","hjxadd","qkcj","vvytxnh","dmbea"}
                    ,new List<string>(){"jvjtcjg","mbiwyad","cup","xkrfk","puz","uxpmutf","rjxyxyn","mfchc"}
                    ,new List<string>(){"ocrak","zprfbgu","pjjzl","zoehfkm","xqn","qki","uxq","tcv","emknqjp","wvmkas"}
                    ,new List<string>(){"nxg","myr","myr","vnfzpoy"}
                    ,new List<string>(){"gwu","ezt","kbmeouj","sxue","cxax","gcquz","ieegnal","xecusia","vxf"}
                    ,new List<string>(){"xermi","xermi","qporwc","mzemns","ticltnz","ddpsstr","ddpsstr","slgbn"}
                    ,new List<string>(){"xnujwtw","bvzv","xjwntuw","unxwtjw"}
                    ,new List<string>(){"tipo","akp","fkmcls","wglmjq","fnrtsv"}
                    ,new List<string>(){"fan","dfbya","qrp","lcvxqqu","ldpm","gucmeky","mrzy","fixaph","rygneb","ocm","pjh"}
                    ,new List<string>(){"ovtrqs","ujmbnal","geihpe","mijhy","eewuic","toaxbp","ipy","tvb","evlmrtd","lbujmna"}
                    ,new List<string>(){"lsmbwwd","hvurk","ihbuek","hvoyq","erzomhn","gue","lpq","dihon","dgzvst"}
                    ,new List<string>(){"fuoshq","hfrzeu","zfrhue","ufqohs"}
                    ,new List<string>(){"icgwnbi","gmhogxu","gmguohx","toixb","hfwj","haxlav","hbe","jdpxeyi","xtgfi"}
                    ,new List<string>(){"vfakk","ioil","hddqu","sdztx","hduqd","bmiuyr","vmas"}
                    ,new List<string>(){"mcvjjhf","sfgt","sfgt","lambvp","dnqc","pfecquk"}
                    ,new List<string>(){"xgr","omy","bmoadg","afbna","mar","nicpazd","iveku","zdioyo"}
                    ,new List<string>(){"rpipon","dwg","wgd","pironp"}
                    ,new List<string>(){"fkyx","wjefuy","mfesst","ztlf","gnnceb","rsbvuk","ckilt","kliqnm","iuifcvu"}
                    ,new List<string>(){"lmgzx","oknwr","wmttry","luipa","vcttj","nuqdmy"}
                    ,new List<string>(){"iota","efrxkk","daqzm","certtoi","nnvqrwz","qrqgza","tllwp","efrxkk"}
                    ,new List<string>(){"alde","wqmdjy","erh","txrtqm","zuljg","hspbnrd","pvsnebh","bkue","pvsnebh","txrtqm","txtthn"}
                    ,new List<string>(){"hgggm","rswwfpj","uctzrv","bylqeen","dpbnw","ostsjwn","jtjiyuh","ofxu","mmmqlg","ayhza","opbgdrv"}
                    ,new List<string>(){"qmhkh","orbeokv","agosach","lhujcju","jzpp","wmxtcy","jcxglu","iuwmzrv","xwkgz","sxlzld"}
                    ,new List<string>(){"dzcdm","lwal","xpujjm","xpujjm","lpfojz","lqqcon","qmqrg"}
                    ,new List<string>(){"gmwugq","ceslt","rxcogaq","jwkraq"}
                    ,new List<string>(){"joxr","brdy","yixlou","brdy","lnr","lnr"}
                    ,new List<string>(){"wbut","pxlsclt","igigapq","zeacg","jxiezn","hvws","wwz","ujpbl","fdjtfjw","opod","kea"}
                    ,new List<string>(){"tsodswf","pufo","zqrt","zvcpu"}
                    ,new List<string>(){"nyy","mrqmg","zkt","tslzsf","zkt"}
                    ,new List<string>(){"hxywv","lbmogd","hhv","npyzgjy","whfvv","mlfqjr","ggjz","owijo","zmesslo","gtvizw"}
                    ,new List<string>(){"xzz","dvpzxbd","wxwlp","cye","rcqpgrr","gynzo","nhy","gzpk","fpfmb"}
                    ,new List<string>(){"nhaakbv","iazpdc","yadqbe","kmqm","dffq","lidnh","cegjosw","kgd","hwivd","wijj"}
                    ,new List<string>(){"cwmdyf","huoy","awihev","qav","cwmdyf","rdwck","hahj","pesfyk","uoju","zrirjdu"}
                    ,new List<string>(){"qabl","vwcwbb","phnd","xnp","huuzwxl","rukbp","kod","sfu","ngcvgrt","buncnfw"}
                    ,new List<string>(){"regyd","gjzfwf","hpuv","zmm","vphu","gwffjz"}
                    ,new List<string>(){"rdf","emo","crsoeo","bksetj","aqfzm","pphny"}
                    ,new List<string>(){"opbmboi","iakvj","ymjwm","vxoq","qvox","yafk","zkch","adlusz"}
                    ,new List<string>(){"qhm","jul","zasv","xhu","qnhjwzx"}
                    ,new List<string>(){"mjmyvd","mezfuls","upbdpzw","awc","qxta","bzrx","tjpjmj","dxfyewc","zorm"}
                    ,new List<string>(){"bko","kfokm","htcpoqc","liuvj","xhmpcu","ccqphot","dthvo","pfj","dtxpmu","xoocm","cmxoo"}
                    ,new List<string>(){"kxv","eenns","qhpfsvo","gqoyv","jzjho","aoscl","fetug","agxmfea","aygpt"}
                    ,new List<string>(){"javmegf","jlmt","epdwy","egfs","hwv","uszcqvn","foixpz","iukh","dbuhqgs","zgb"}
                    ,new List<string>(){"zrex","zrex","xtx","ydan","maomp","hqdhh","mfvan","broh","wvwhqbu"}
                    ,new List<string>(){"phatsot","joipm","pmniq","arqzmbe","vurl","bgy","iwbwk","oyhngcv","vnzbzgm","bgy"}
                    ,new List<string>(){"xprufgn","vhca","nrs","abuh","zwsxmhk","mqrj","tyslsij","ojkdzom","wepxg","koodzv","ypvyy"}
                    ,new List<string>(){"vop","nnpz","mcod","mlli","ntyhz","laqztb","kauqkla","gmrfte","pcuhaci"}
                    ,new List<string>(){"vrenj","lypors","prknc","djbdkzv","amofdx"}
                    ,new List<string>(){"lgig","lojnrw","obusoc","fkwe","ggnv","pydcraq","bvdivl","vev","mrojjs","rxa"}
                    ,new List<string>(){"qeg","tap","jocwlsm","vqxa","lmjscow"}
                    ,new List<string>(){"gptlrgq","vdasm","erdc","oparmw"}
                    ,new List<string>(){"rgbsa","nacqhvm","pczf","anupcp","upudwgp"}
                    ,new List<string>(){"jbnobi","ifhzrd","ihrkkf","osw","wos","lrnwv"}
                    ,new List<string>(){"aiuntpl","fcxpmz","fplacs","fplacs","tipm","gfotkx"}
                    ,new List<string>(){"fsbnd","qoc","ozmbi","rqv","fmbxh","tuso","kfoxvjn","ocja","zzs","jwplx"}
                    ,new List<string>(){"muaklvq","ghozoxh","nwxbh","mgoou","ufptl","ouhh","reyuf","jougckd","dgprag"}
                    ,new List<string>(){"gwbnqwv","dtrd","mkzxinl","erxl","zmfa","skuu","crxmp","wwao","wwvdpk","nxbn","lglzy"}
                    ,new List<string>(){"qeejk","wvnypc","yfzyfcr","eeqkj"}
                    ,new List<string>(){"nmcp","fmkgfyi","grfthau","azw"}
                    ,new List<string>(){"kkallxz","rjke","ukbt","ixkhfb","bktu","jkre"}
                    ,new List<string>(){"pxj","mnwe","djrjde","gpsc","enqz","pdbydx","cktfs","jjeddr"}
                    ,new List<string>(){"mgplj","yyunujc","vis","odee","ccesa","yyg","yjcnuyu","doo","utse"}
                    ,new List<string>(){"flyy","juvxomm","vcdcyva","lfyy","ozxnuzw","bmgns"}
                    ,new List<string>(){"kmsypi","zpbyiv","rrycnb","qos","sslwyeo","jgbyv","njltzt","fuwk","nwfb","ozcf","xqnf"}
                    ,new List<string>(){"sdcvgmy","sdcvgmy","hzv","uyq","sdcvgmy"}
                    ,new List<string>(){"fyox","vmgxahj","ywaxbmm","ugy","ruwc","mys","yrjwr","ozsxb","vaq"}
                    ,new List<string>(){"gjpyc","sgdn","kgm","fbvq","cziui","nzy","bwu","ezjkkus","jrag"}
                    ,new List<string>(){"kxcr","tgjxss","xkcr","bembjv","rbbiw","bwbri"}
                    ,new List<string>(){"dcz","rrhvdc","zbonfzy","ubjt"}
                    ,new List<string>(){"rvq","yjnzswt","vatkopb","xlj","dwxig","dqlt","qts","iva"}
                    ,new List<string>(){"lylclc","jptz","rbidu","lbt","byxk"}
                    ,new List<string>(){"lwre","vwriwh","afixsi","vwriwh"}
                    ,new List<string>(){"kmvbflr","nfptw","fbglxh","pyas","dxmn","hemf","segaz","zrs"}
                    ,new List<string>(){"dvbey","zmj","xfoi","bma","udtxhb"}
                    ,new List<string>(){"yryng","geiwgz","bbrvjp","ala"}
                    ,new List<string>(){"olzicp","olzicp","qhhslry","olzicp"}
                    ,new List<string>(){"exf","xdmwh","xdwhm","nhjsssn","rmlkdb","excguia","fex"}
                    ,new List<string>(){"xkwgeso","htys","sjdk","jizciy","gjjl","phgqdjh","wzdb","izew","zcrumu","llxfp"}
                    ,new List<string>(){"frkohf","oifsm","aisebkt","ijsfkot","ukk"}
                    ,new List<string>(){"koqf","xvoior","tpe","erfpnp","npnx"}
                    ,new List<string>(){"sneysk","nsxki","wpmhd","mdor","akrpvgz","moicncj","sbsj","owfhj","exw"}
                    ,new List<string>(){"oqqbvk","xztx","gtxlms","icmo"}
                    ,new List<string>(){"lfy","ltq","dlzqlvi","ovbrsa","gzm","nhcjq","umbtgm","nhcjq"}
                    ,new List<string>(){"iuopdzq","cqaeuu","xuzngq","kxlx","laml","slvvr","frtml","tvioiez","vyoomw","xickbqh"}
                    ,new List<string>(){"ckahov","mepeku","gtaf","gtaf"}
                    ,new List<string>(){"tlto","cnnz","kzsbkjo","kzsbkjo"}
                    ,new List<string>(){"kqf","comkf","dvrkyl","jdsqi","rnwvb","vxvd","pok"}
                    ,new List<string>(){"hncq","xcx","yuykfs","egrruvw","yqh","smcou"}
                    ,new List<string>(){"tywyq","xeq","cix","yywqt","jhzptci","hybcoe"}
                    ,new List<string>(){"zsw","zsgot","wnu","sumd","azmuos","qawjaz","rpf","zkxgwdu","iom","igh"}
                    ,new List<string>(){"vmxmelt","gll","ysbbt","yboqoyz","ykdglk","cnypf","otn","owsz","ipn","epfeka","bkmy"}
                    ,new List<string>(){"wxjpce","etzyavi","whb","sxzft","bfu","dgwnbgc","nfw","sxcteis","qqpk"}
                    ,new List<string>(){"kofv","dgoyme","vlza","oxhbo","lrqt","uic","tvfqiyy","iaqm","afnk"}
                    ,new List<string>(){"nsmpg","wkibdcz","dxbw","tlxzm","zgwe","nqwjji","eacbhn","blk"}
                    ,new List<string>(){"shlgws","eencr","rtufah","kjyvqw","transt","ecsq","otbf"}
                    ,new List<string>(){"obs","xsjceex","ffqj","sob","djpq","jcda","zlskve"}
                    ,new List<string>(){"rfqtle","klarp","mtzrx","rasr","eisqovk","rpt","vymibt","zwrif","ilsnd"}
                    ,new List<string>(){"ldu","ffd","ldu","tizfexr","fwpmyan"}
                    ,new List<string>(){"flxso","tzec","pzn","flxso","kzdouon","tkvkj"}
                    ,new List<string>(){"tvd","arh","qywql","uev","btvnpm"}
                    ,new List<string>(){"wtwx","kzafvk","ybyzmhv","mdbrphy","vamlvr","gbxhod","tyulba","krcqj","ikotmla","qfhpa"}
                    ,new List<string>(){"bnfin","ebngj","agfdfzu","rhjtj","aaqzh","fsyp","nilar","uwurjnu","hhmso","hhmso"}
                    ,new List<string>(){"uanmesj","vshh","syosjdt","xkormf","syosjdt","ifvytwl","qnw","vshh","jkg"}
                    ,new List<string>(){"epyzcn","pgdxgye","lecnx","nebg","jzdhvge","hfy","imiyft"}
                    ,new List<string>(){"zonbcnv","vuvg","sxtuty","zdhmiow","lmud","cuegzg"}
                    ,new List<string>(){"bxgft","mxhzrh","unqd","pqpsnce","khykn","qlb","oujdxpq","pxrd","jzxjuxr","tij"}
                    ,new List<string>(){"qss","mqirowz","ijjswjm","jjer","utwn","kuedqxx","bxshuok","qkfag","dmfwcr"}
                    ,new List<string>(){"jgln","zdohd","xitfbge","xbokj","xxeuv","wqhvhjo","erg","cua","fhc","mhwy"}
                    ,new List<string>(){"euo","ousht","ipxt","tpzq","vnbmlo","wvbjpb","yjg","bwpjbv","nzvsea","aerhsqv"}
                    ,new List<string>(){"axhmi","bcf","zdx","vplso","xhmai","qsk","psolv"}
                    ,new List<string>(){"ydnpmyo","pfba","zmo","nat","ykwxvm","ydnpmyo","rtd","uuvqqr","hcfccbd","rtd"}
                    ,new List<string>(){"ytp","guw","ydmyf","rww","oucmpf","gemhpj","labc"}
                    ,new List<string>(){"edpbefn","awgg","qzpe","aat","cupig"}
                    ,new List<string>(){"mmi","ghdaoh","ibx","fbyj","gge","vmmssen","nplt","mmqcra","omcvm","uwa","fxypxfc"}
                    ,new List<string>(){"kjaw","mtijne","cfmsigd","zwcjjd","ajxjlqr","tbp","bnilc"}
                    ,new List<string>(){"fse","ele","vcsyiv","bfe","udny","vznrao","mgrjfgw"}
                    ,new List<string>(){"hadl","nikvvpf","gmdg","bkmgt","ugj"}
                    ,new List<string>(){"xkis","qmr","cgz","nresp","gms","zrii","coxkke","vfsqiil"}
                    ,new List<string>(){"wmicbf","bkk","wcwklfg","vpcbeg","kfmjab","vabc","dax","tnao","tnao","fvvzeyq","fqm"}
                    ,new List<string>(){"bct","tvj","tra","soo","stqao","kqua","ikupoy","wulcu","nauxkkb","pvqxy","bfu"}
                    ,new List<string>(){"wpz","txdduxq","gaehfki","kxo","lvjzpxu","iqon","swr","eyihl","nbbec"}
                    ,new List<string>(){"fuphnbj","bdtz","huwu","zdtb","ilgzpa","uyaut","vpy","viff","tuuya"}
                    ,new List<string>(){"cvusbh","bgy","apsao","qsupha"}
                    ,new List<string>(){"jtzlbd","ljfvh","wkjrw","xsah","sef","jygb","pqym","zbcwok","zdmug","qpym"}
                    ,new List<string>(){"hbibuax","iorqc","dqjrs","daeb","iorqc","qiw","sagyt","rkc","sagyt","khbr"}
                    ,new List<string>(){"shz","mgn","pqrdbm","jvace","gfhnq","ann","zosq","wdwzmuf","kswsg","dzt","brlavyo"}
                    ,new List<string>(){"qiw","cdvwds","dckpruy","pybjra","lfvgfn","cwj","bajtud","pojehb","rzrzvwe"}
                    ,new List<string>(){"txfyk","zkgeeu","zkgeeu","zkgeeu","wskcv","nccoz"}
                    ,new List<string>(){"eettnxq","gbgr","uiqonyz","wqtgs","ozfjbn","gbgr"}
                    ,new List<string>(){"svd","thmmr","rbbtxn","sxkq","isxlnhf","tamdlbe","bqrgvu","nmpvlkc","spko"}
                    ,new List<string>(){"qmn","rspbjme","ikjddkq","kdb","ugpegi","egipgu"}
                    ,new List<string>(){"ufffijo","revqpep","zfw","kwd","pnya","blqo","rnntzx","anpy"}
                    ,new List<string>(){"piaeyf","vbeye","uuqd","vbeye"}
                    ,new List<string>(){"hamd","hap","ekk","lgla","twto"}
                    ,new List<string>(){"isniinr","crz","sjpmfxn","uskwj"}
                    ,new List<string>(){"lzeofk","tavbq","ijcglqy","lvy","jliqcyg","lwlip"}
                    ,new List<string>(){"uhyyyw","itlrf","tdc","iabeocv","jzwnjh","vqxll","nefze","pyrxmx","eispxnm","hzlksce"}
                    ,new List<string>(){"ucuh","mlam","bhyej","rgzkew","ctbo","iswqnvg"}
                    ,new List<string>(){"ytmb","toppqgp","ytmb","gqgpr","gqgpr","vps","ebv"}
                    ,new List<string>(){"eavn","atkqltv","bjvojs","kaskr","vqltakt","uiktr","xglc","eyb","rkkas","fhnf","eaorqm"}
                    ,new List<string>(){"jmfipc","ujggeh","hdxpfa","xtab","ydkibi","ycxn","ujggeh","icheh","vpznael","oprbf"}
                    ,new List<string>(){"xazqxg","khlemu","awh","uwz","vhnixk","vdcty","hkk"}
                    ,new List<string>(){"gcl","kayi","hfozask","grpseyn","zviy","tzoum","qywnr","wqkhq"}
                    ,new List<string>(){"ctrrcpw","wqfbylp","wqfbylp","wqfbylp"}
                    ,new List<string>(){"gtk","lqohf","hqeaku","mdj","zrfkmxn","bcqgf","msing"}
                    ,new List<string>(){"luhpel","kexokpx","vojap","ldaexs","bbbtz"}
                    ,new List<string>(){"oimnqb","esg","zyjmbfh","dfyhcf","khpo","zjtgm","yelztbs","ugj","zjtgm","mxro","xyfxpk"}
                    ,new List<string>(){"dgtsu","vvk","wwfugbx","aai","zlxab","beyxcg","bpx","chc","bnxui"}
                    ,new List<string>(){"irrwbo","orwibr","lqt","qtl","tqknh"}
                    ,new List<string>(){"ihjsg","ihjsg","powwy","pycyqo","ihjsg"}
                    ,new List<string>(){"xdcu","outh","fnqrc","eihkss","bdylm","sjunib","eihkss"}
                    ,new List<string>(){"jpnw","ycimse","rffu","ismyce","uhxl","feai"}
                    ,new List<string>(){"yyodnh","dvwshkx","vulh","pvxj","ydhyno","hyodny"}
                    ,new List<string>(){"vuuweg","pfguvyu","orhei","orhei","wrm","amkr","xecja","lmnveth"}
                    ,new List<string>(){"wriwe","xgtnvj","tdmxf","gadtqh","bezjvz","lifu"}
                    ,new List<string>(){"euft","tchbm","xmtlwji","tchbm"}
                    ,new List<string>(){"cfi","zudn","zludl","pwiu","axe","psed"}
                    ,new List<string>(){"dbtfwf","ajxcudj","uaxdjcj","dxuajjc","zouyy"}
                    ,new List<string>(){"fmycmej","bqhe","jyfecmm","kkrv","kcdvjoy"}
                    ,new List<string>(){"grtb","uzs","rkxzt","hivhic","brtg","hwyc","lsl","iivhch","qbcp"}
                    ,new List<string>(){"ymn","xfpka","hqm","sldz","dblvsoe"}
                    ,new List<string>(){"qrcapma","hntgmy","difrkpk","difrkpk","xlsph"}
                    ,new List<string>(){"flvqh","akcw","boxrz","ywhq","boxrz","esnxzv","boxrz"}
                    ,new List<string>(){"zrvh","jskaw","mfs","fkj"}
                    ,new List<string>(){"abveb","qxfnlfq","abveb","kbwiyvd","abveb"}
                    ,new List<string>(){"pgarl","nbfrenx","rnxgx","bdlkix","liltdm","dzcokeg","fubupcg","iwp","xfayp","obfaz","nevfw"}
                    ,new List<string>(){"nuhvaci","blyv","fcsp","adlanka","sjy","syj","ysxl"}
                    ,new List<string>(){"avwakn","dkoya","yzuszuk","lqrr","oqfyd","dmgbhd","lqrr"}
                    ,new List<string>(){"pxa","mcvtoug","nlweso","yffqc","dtuagcd","ovvrkz","ggfhw","wnlseo","bpqbn","ohxzs","rxzo"}
                    ,new List<string>(){"djkcl","kbgyfir","ogquot","uoqotg","jtmyd","ohudvle","xrnbt","yvsln","wykqt","hntc","xlrhqrb"}
                    ,new List<string>(){"ykt","tkxfmd","exas","kty"}
                    ,new List<string>(){"zebstke","msbbndq","itmli","ubexmht","vekvd","xbmb","iajbj","wac","sta"}
                    ,new List<string>(){"ptdg","oftwo","goiulah","tfmsrqs","jffxvnv","ozaluj","qlhqjy","wyffa"}
                    ,new List<string>(){"xeq","ezmlpw","xgno","xorvfo","yzq","vwif","wsi"}
                    ,new List<string>(){"hdove","hqbzhu","pjrxlj","uafuh","rizlb","advmkca"}
                    ,new List<string>(){"jzk","ddoisdh","tfjh","yuvikps","ixpkf","hnu"}
                    ,new List<string>(){"kixa","djx","uksr","ogxty","dxj","clda","ukrs"}
                    ,new List<string>(){"xgiy","diwbvn","vphdbg","qnelyz","tqptqig","lenyzq","ecsswj"}
                    ,new List<string>(){"alx","awj","fpasmmg","zukuh","qaanvb","too","nvskuk","too","gnria"}
                    ,new List<string>(){"suo","suo","brw","nazq","suo","dqv"}
                    ,new List<string>(){"tan","uxiz","oqa","xyezcd","lsaicjr","bosiak","rmmh"}
                    ,new List<string>(){"bidpomf","dimcj","qekero","wbrc","lewt","kmgmlao"}
                    ,new List<string>(){"bciacj","eye","lxfpef","cbdshd","dhdsbc","qwnhil","iuokc"}
                    ,new List<string>(){"zduefht","lrgfjn","nclksm","wpjpjr","hkeqd","oprsjcw"}
                    ,new List<string>(){"chhdr","bram","swdfjr","yikqra","xkzsloc","otptp","agec","hhdrc","uofljf","toppt","wpbyrwo"}
                    ,new List<string>(){"bwlpb","nishr","knnrysj","bvr","ftnb","iedskch","weo"}
                    ,new List<string>(){"czo","hsfp","wblh","cru","kzalun","intt"}
                    ,new List<string>(){"jvob","rppz","rkwv","hgyhrqg"}
                    ,new List<string>(){"sgo","hued","jnygge","izf","ztan","kjgpcn","fagff","jsi","ijcxzoi","tgqjjp","tgqjjp"}
                    ,new List<string>(){"ltjq","zidjy","rfmy","yevuaa","nlhfyg","xytdtle","wsqvzzx","wfflboo","nawhv","golhf","xhsti"}
                    ,new List<string>(){"bmtzlml","xcbsquq","vnfsux","voep","lkss","ioim"}
                    ,new List<string>(){"ntfffh","gcncwu","mmymn","wkwlswa","gcncwu","iaeyumz"}
                    ,new List<string>(){"kcgdm","rbaau","cwsoya","pznnnn","xzz","zbbdlhw","zxuelq","xzz","pjeq"}
                    ,new List<string>(){"xrmnuct","kwvykx","khxr","ioua","xnmtrcu","xrnctum","ujq","imnt","ecee"}
                    ,new List<string>(){"xjsgx","fby","fby","fby","ggtpgdm","jqvuj","qshewki","tkml","ymsazcq"}
                    ,new List<string>(){"sdbyhwg","kewtrte","novhdcp","wbuaoh","dtytgtx","zez","whygbds","hpg"}
                    ,new List<string>(){"tjvaqo","yrycda","yrycda","ldbp","yrycda"}
                    ,new List<string>(){"kloi","tmsocmx","dza","sqtxc","wgevs","zlevs","vtm"}
                    ,new List<string>(){"ftnx","drvdm","ryjfdgw","nerynh","cwfjpa","mddvr"}
                    ,new List<string>(){"wsqjyn","svg","ncw","aesn","hvuq","vybajti","aesn","bql","atxhp","ipu"}
                    ,new List<string>(){"eye","romgxj","gumuke","jwi","jrf","dtt","kcj","wmg","waw"}
                    ,new List<string>(){"ptltud","oymklv","fgnmbc","ete","apanovb","vpt","vyospi"}
                    ,new List<string>(){"clkguhu","rbxs","lxtnmy","ferdx","qbmrpg","pvojnj","zbcffbp"}
                    ,new List<string>(){"itngp","dvtlq","fzxp","cxrf","gbxxqp","aafls","pfe","bpxgxq"}
                    ,new List<string>(){"nmikrui","ddsq","srfilr","gnuvghu","mwnacz","nlbdm","zcjm","uylgev","umzu","mftz","nmikrui"}
                    ,new List<string>(){"bow","jmnxyen","bow","hvz"}
                    ,new List<string>(){"lksibxk","lefzh","lksibxk","nkxsi","nkxsi","pldvhk"}
                    ,new List<string>(){"osjlzns","pihvr","zpeu","zxjgjb","xplykfk","xplykfk"}
                    ,new List<string>(){"hajmfss","cardd","kaddjw","uicfde","taue"}
                    ,new List<string>(){"rgwdjra","sgifh","ggt","mpzx","usghkos","oob","fvzx","ghnyxr","sblcif"}
                    ,new List<string>(){"dtu","gnihpry","kjdpiny","xvax","itmluk","fxvgaap","bei","xuq","wzcy","rhb","hailtgo"}
                    ,new List<string>(){"wwob","ueldq","ueldq","glxc","umimwv","onu","dxhmhis","ebottoa","lnysfiu"}
                    ,new List<string>(){"zfbyi","eyq","etaj","idpbkf"}
                    ,new List<string>(){"qshcfjb","ozzqigv","raztm","ymcv","sgivwoc","kightf","dcaglk","udah","fdm"}
                    ,new List<string>(){"jmxr","jrcnck","enffwfl","jycc","jmxr","cylnigo","enffwfl"}
                    ,new List<string>(){"bkslhv","tykqw","tykqw","mbeqrbt","tykqw"}
                    ,new List<string>(){"vogf","nhqltpt","nhqltpt","vogf","kpc"}
                    ,new List<string>(){"ryayz","ddktu","rfhkmx","xok","xninjcm","ijcrw","fxu"}
                    ,new List<string>(){"cmezfj","zaamjrs","whlcuoo","mug","lcaqhkb","ymkdci","qexa","onhgk","pgy"}
                    ,new List<string>(){"hcrcok","qri","fki","wbiog","ptj","pmgtdt"}
                    ,new List<string>(){"xsl","mpfxwbz","bmzxpwf","hrysu","bmfxwzp","xfja"}
                    ,new List<string>(){"gybzho","ktokndy","rzkbr","jcnp","ahicq","weccg","pgrodkt","che","vaglyn","omhmpo"}
                    ,new List<string>(){"vdv","bngjox","srs","faymg","xrmf","enseu","aygfm","gvsd"}
                    ,new List<string>(){"nuzi","xodkbag","eevovl","bfjuv","nuzi","xmejqn"}
                    ,new List<string>(){"kcswegw","bpa","dgil","insf","insf"}
                    ,new List<string>(){"stg","tklrut","poi","knurfpf"}
                    ,new List<string>(){"pcs","dgirfie","yep","lvkfk","ype","hntt","athvad","clfybsq","ofjhegj","epy","qwawns"}
                    ,new List<string>(){"wjtpgd","wjtpgd","vxnapp","mwyfsm","vxnapp","rvcswcs","jksa"}
                    ,new List<string>(){"ckzslrg","wdzeimw","cqhp","nfgk","zgukvd","yyt","tra","erkx","wdzeimw"}
                    ,new List<string>(){"hsww","avl","vkmzej","hsww"}
                    ,new List<string>(){"mum","oczj","jfew","rag","zjoc","wjfe","yqynjqt","cbkcsgo","mri"}
                    ,new List<string>(){"vjhfqdi","vjhfqdi","npfa","pzdmy","utlyw","bwvbfm","nqdv","iiap","ygpky","bwvbfm","eocya"}
                    ,new List<string>(){"ewkqi","ckb","yviuro","mqz","vtrdam","yzkqzv","ppbj","lhmj","blkafo","juxvwke","lvewc"}
                    ,new List<string>(){"ljrewgx","sutnb","hfsavbu","jofr","ltml","mjzkzz","nmjii","sutnb","eonegt"}
                    ,new List<string>(){"cxzv","nepyrb","wmejdo","vwqi","aeqys"}
                    ,new List<string>(){"sbx","fmne","obzdz","rdnfb","gmb","sbx","ykcae","hbzom","ncwju","rhpiao","obzdz"}
                    ,new List<string>(){"lsgfun","cbmfjwk","fya","ktzxbwt"}
                    ,new List<string>(){"ica","bpsk","bwjwkp","obloxdx","uwoqdo","bnnhjuc","tlsx","qtaacp","bdooxxl","jamy","ade"}
                    ,new List<string>(){"psus","wmtkg","ikvfx","fkvesj","upqlhfs","ueje","nyt","abxvo"}
                    ,new List<string>(){"adlbl","hzskbrp","ooht","nps"}
                    ,new List<string>(){"wtcgnvy","nvqtvx","tvgnycw","ntvcygw","kkxcp","zyjmpbh"}
                    ,new List<string>(){"xfxww","xsddqe","ewvmgw","qxqwy","wpabtz","ppe","zuiw","zubcc","onaqii"}
                    ,new List<string>(){"kkaeec","xhcakul","wrrvi","dtlqfy","ahqdilw","bnt","gwimw","espaivx","nam","yfv"}
                    ,new List<string>(){"lxz","jtc","nkwgz","nbgsao","olsck","emtltf","xidwcvm","lcjxq"}
                    ,new List<string>(){"eav","dzh","hnbp","hnbp","yeg"}
                    ,new List<string>(){"egaq","yvat","kavsige","csar","zsi","sptai"}
                    ,new List<string>(){"pofijc","ibdnoe","caoazp","azlnjk","dqp","chik","lowll","iby","gpvjv","ohm"}
                    ,new List<string>(){"ors","lexk","zcneaj","rmesx","jman","uqkb","kvkq","zfufmn"}
                    ,new List<string>(){"qgsyzxd","hlm","juerg","ortfzw","hxjzg"}
                    ,new List<string>(){"fxwy","lcoc","fyxw","pzhynp","yfn","zdzrz"}
                    ,new List<string>(){"datmws","ckwghgr","gbtyf","lqrpfgl","mbgpd","dyjilr","fgybt","hxpg"}
                    ,new List<string>(){"mxw","facxdnu","wxm","urltwtf","qfo","wtpwrj"}
                    ,new List<string>(){"esa","srypq","jauwv","dpm","wdgqq","hrke","icvudq","bdmubb","ellhfjh","ttpjjd","gxmg"}
                    ,new List<string>(){"gvwvqwj","cbzzuvj","eckube","adqinpa","djutlue","wcpw","vrt","ucqwu","ekruwsn"}
                    ,new List<string>(){"fhj","fst","zmtb","yhwk","dxlbozs","fcb","vjvuxin","dxlbozs","rixdvu"}
                    ,new List<string>(){"egfoep","cvq","icd","prwj","icyg"}
                    ,new List<string>(){"aojaa","ezmcuf","udreyi","bja","cyrtpl","wjl"}
                    ,new List<string>(){"gjeka","bsbufp","tbqqq","vbmnqg","sfqtgac","odhq","xzsxt"}
                    ,new List<string>(){"yse","gujdr","ugjdr","sye"}
                    ,new List<string>(){"tax","hntqw","phf","eixjwfh","qkylnu","nkyuql","ugsuj"}
                    ,new List<string>(){"wyh","egum","zizhfc","jrq","htbyug","lop","dsu"}
                    ,new List<string>(){"exh","vfdoosj","ajrna","jbiaz","lqsgvks","xklqgjv","abtmdud"}
                    ,new List<string>(){"juqc","ormfa","sab","tucsfln","detqfo","feg","kifsion","juqc","ovhra"}
                    ,new List<string>(){"hvcrh","oddhme","omzmu","vmy","she","xulvfa","fecmgi"}
                    ,new List<string>(){"ayo","gspge","nkmy","yblsj","lrsre","nkmy","pwocjz","gdexqqx","ovovm"}
                    ,new List<string>(){"acy","sqcz","ijl","htt","yjsi","rly","vea","bck"}
                    ,new List<string>(){"bniafe","yore","xnh","rkcfd","hxfuzw","xlr","nkzmmcs","ekwggiu","kgoboi","wfuzxh","hwfxuz"}
                    ,new List<string>(){"weq","crkeq","cccphe","dtozviy","kzkkdr","yku","cephcc","ctq","zbau","dewpi"}
                    ,new List<string>(){"vfla","rzpl","bnmx","uvggon","foivrb","fval"}
                    ,new List<string>(){"ziaove","lawkpdn","ddwl","sxj","krroj","rqmffxv","babb"}
                    ,new List<string>(){"bdw","dsifr","kuueet","hugddwt","piz","dwb","sjixveg","kmsoknq"}
                    ,new List<string>(){"czl","feyxf","soyvbj","tnmpjn","kklwi","akx","nqepntc"}
                    ,new List<string>(){"nrmhc","tkkn","jrxgc","jrxgc","tkkn"}
                    ,new List<string>(){"ufzn","mrhiapi","qrme","kjlf","qrme","xpp","qrme","loyzizz","xqm","coli"}
                    ,new List<string>(){"qvaoye","mysv","ydfxr","iixrw"}
                    ,new List<string>(){"dql","tqarux","fxqfn","haoinu","lyati","xml"}
                    ,new List<string>(){"kyve","obatly","dgfjt","fjz","sqrz","xlbst","lgwlt","zovih","aepy","otrpl","oifid"}
                    ,new List<string>(){"ymawam","afgye","lcnpkmv","feilfws","vonseh","rxrdco"}
                    ,new List<string>(){"tqij","kuawg","dmova","slds","imdtb","sjsafo","ffkzzl","pxxenva","wuakg","efbgx"}
                    ,new List<string>(){"yrwoaos","vpw","ijjpua","jnbxl","sev","yvgdxzr","mpqa","vpe","lboh","sev"}
                    ,new List<string>(){"krwdtd","uglxtcz","mljcgdk","lqj","fgpfle","nuui","cqk","exr","nuu","oyn"}
                    ,new List<string>(){"dwd","nwt","idhclm","vgkh","rpubq","wybhapp"}
                    ,new List<string>(){"hskhgpy","gzvz","jztbr","jwv","vcx","vdjmnjr","jrsp"}
                    ,new List<string>(){"ikml","ceuhcng","biu","zoo","gra","bnnforx","abzan","hwsmd","lmki","tsl","yvogo"}
                    ,new List<string>(){"kqfc","younaz","azvgfz","gesajr","tmwxvyb","vmcdu","dclwh","rfjwhic","slfym"}
                    ,new List<string>(){"pbrhjml","rsacryg","jga","qvgks","neh","fcq","qmi","mwb","juezk","mjteeg","alkb"}
                    ,new List<string>(){"pcj","ujstl","fkrqm","eeczrle","hbkcvm","upbo","mrb","qrspjt"}
                    ,new List<string>(){"jbq","rrk","xjl","rgokbnx","hor","ogg","szxqu","hysy","vqj","piorq","wtrtrdk"}
                    ,new List<string>(){"bnq","ntvhcrf","vrm","puer","kde","xaxkja","sfxgjf"}
                    ,new List<string>(){"pgcicus","hqeqkkx","xqekqhk","qqkxhke"}
                    ,new List<string>(){"puquxi","hmeaehh","oxe","tasipw","qzyg","hyvy","wcmpwe"}
                    ,new List<string>(){"hvs","fxq","wvfy","zjepsl","dvrfxnc","xnvg"}
                    ,new List<string>(){"xle","crcuc","qkhnv","crcuc","oedez","bjw","pmwq"}
                    ,new List<string>(){"xzzpiy","cjwss","jwscs","apb","bpa"}
                    ,new List<string>(){"ydjhhf","yeltadb","lwi","cjdcb","ovaox","xrdm","vkxub"}
                    ,new List<string>(){"zax","xza","admbc","lvpzfeh","auxn","rwasj"}
                    ,new List<string>(){"kebx","eild","nrskdr","meja","jxczomh","gcne"}
                };
        }
    }
}
