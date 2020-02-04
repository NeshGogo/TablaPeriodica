using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablaPeriodica.Models;

namespace TablaPeriodica.Controllers
{
    public class TablaPeriodicaController : Controller
    {
        public IActionResult Index()
        {
            var elementos = GetElementos();
            return View(elementos);
        }

        private List<Elemento> GetElementos()
        {
            var elementos = new List<Elemento>
            {
                new Elemento{ Id="1", Name = "Hidrogeno",Initials="H",Category = CategorisEnum.OtrosNoMetales },
                new Elemento{ Id="2", Name = "Helio",Initials="He",Category = CategorisEnum.GasesNobles },
                new Elemento{ Id="3", Name = "Litio",Initials="Li",Category = CategorisEnum.Alcalinos },
                new Elemento{ Id="4", Name = "Berilio",Initials="Be",Category = CategorisEnum.Alcalinoterreos },
                new Elemento{ Id="5", Name = "Boro",Initials="B",Category = CategorisEnum.Metaloides },
                new Elemento{ Id="6", Name = "Carbon",Initials="C",Category = CategorisEnum.OtrosNoMetales },
                new Elemento{ Id="7", Name = "Nitrogeno",Initials="N",Category = CategorisEnum.OtrosNoMetales },
                new Elemento{ Id="8", Name = "Oxigeno",Initials="O",Category = CategorisEnum.OtrosNoMetales },
                new Elemento{ Id="9", Name = "Fluor",Initials="F",Category = CategorisEnum.Halogenos },
                new Elemento{ Id="10", Name = "Neon",Initials="Ne",Category = CategorisEnum.GasesNobles },
                new Elemento{ Id="11", Name = "Sodio",Initials="Na",Category = CategorisEnum.Alcalinos },
                new Elemento{ Id="12", Name = "Magnesio",Initials="Mg",Category = CategorisEnum.Alcalinoterreos },
                new Elemento{ Id="13", Name = "Aluminio",Initials="Al",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="14", Name = "Silicio",Initials="Si",Category = CategorisEnum.Metaloides },
                new Elemento{ Id="15", Name = "Fosforo",Initials="P",Category = CategorisEnum.OtrosNoMetales },
                new Elemento{ Id="16", Name = "Azufre",Initials="S",Category = CategorisEnum.OtrosNoMetales },
                new Elemento{ Id="17", Name = "Cloro",Initials="Cl",Category = CategorisEnum.Halogenos },
                new Elemento{ Id="18", Name = "Argon",Initials="Ar",Category = CategorisEnum.GasesNobles },
                new Elemento{ Id="19", Name = "Potasio",Initials="K",Category = CategorisEnum.Alcalinos },
                new Elemento{ Id="20", Name = "Calcio",Initials="Ca",Category = CategorisEnum.Alcalinoterreos },
                new Elemento{ Id="21", Name = "Escandio",Initials="Sc",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="22", Name = "Titanio",Initials="Ti",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="23", Name = "Vanadio",Initials="V",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="24", Name = "Cromo",Initials="Cr",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="25", Name = "Manganeso",Initials="Mn",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="26", Name = "Hierro",Initials="Fe",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="27", Name = "Cobalto",Initials="Co",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="28", Name = "Niquel",Initials="Ni",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="29", Name = "Cobre",Initials="Cu",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="30", Name = "Zinc",Initials="Zn",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="31", Name = "Galio",Initials="Ga",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="32", Name = "Germanio",Initials="Ge",Category = CategorisEnum.Metaloides },
                new Elemento{ Id="33", Name = "Arsenico",Initials="As",Category = CategorisEnum.Metaloides },
                new Elemento{ Id="34", Name = "Selenio",Initials="Se",Category = CategorisEnum.OtrosNoMetales },
                new Elemento{ Id="35", Name = "Bromo",Initials="Br",Category = CategorisEnum.Halogenos },
                new Elemento{ Id="36", Name = "Kripton",Initials="Kr",Category = CategorisEnum.GasesNobles },
                new Elemento{ Id="37", Name = "Rubidio",Initials="Rb",Category = CategorisEnum.Alcalinos },
                new Elemento{ Id="38", Name = "Estroncio",Initials="Sr",Category = CategorisEnum.Alcalinoterreos },
                new Elemento{ Id="39", Name = "Itrio",Initials="Y",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="40", Name = "Circonio",Initials="Zr",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="41", Name = "Niobio",Initials="Nb",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="42", Name = "Molibdeno",Initials="Mo",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="43", Name = "Tecnecio",Initials="Tc",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="44", Name = "Rutenio",Initials="Ru",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="45", Name = "Rodio",Initials="Rh",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="46", Name = "Paladio",Initials="Pd",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="47", Name = "Plata",Initials="Ag",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="48", Name = "Cadmio",Initials="Cd",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="49", Name = "Indio",Initials="In",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="50", Name = "Estaño",Initials="Sn",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="51", Name = "Antimonio",Initials="Sb",Category = CategorisEnum.Metaloides },
                new Elemento{ Id="52", Name = "Telurio",Initials="Te",Category = CategorisEnum.Metaloides },
                new Elemento{ Id="53", Name = "Yodo",Initials="I",Category = CategorisEnum.Halogenos },
                new Elemento{ Id="54", Name = "Xenon",Initials="Xe",Category = CategorisEnum.GasesNobles },
                new Elemento{ Id="55", Name = "Cesio",Initials="Cs",Category = CategorisEnum.Alcalinos },
                new Elemento{ Id="56", Name = "Bario",Initials="Ba",Category = CategorisEnum.Alcalinoterreos },
                new Elemento{ Id="57-71", Name = "Lantanidos",Initials="La-Lu",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="72", Name = "Hafnio",Initials="Hf",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="73", Name = "Tantalo",Initials="Ta",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="74", Name = "Wolframio",Initials="W",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="75", Name = "Renio",Initials="Re",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="76", Name = "Osmio",Initials="Os",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="77", Name = "Iridio",Initials="Ir",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="78", Name = "Platino",Initials="Pt",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="79", Name = "Oro",Initials="Au",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="80", Name = "Mercurio",Initials="Hg",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="81", Name = "Talio",Initials="Tl",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="82", Name = "Plomo",Initials="Pb",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="83", Name = "Bismuto",Initials="Bi",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="84", Name = "Polonio",Initials="Po",Category = CategorisEnum.Metaloides },
                new Elemento{ Id="85", Name = "Astato",Initials="At",Category = CategorisEnum.Halogenos },
                new Elemento{ Id="86", Name = "Radon",Initials="Rn",Category = CategorisEnum.GasesNobles },
                new Elemento{ Id="87", Name = "Francio",Initials="Fr",Category = CategorisEnum.Alcalinos },
                new Elemento{ Id="88", Name = "Radio",Initials="Ra",Category = CategorisEnum.Alcalinoterreos },
                new Elemento{ Id="89-103", Name = "Actinidos",Initials="Ac-Lr",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="104", Name = "Rutherfordio",Initials="Rf",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="105", Name = "Dubnio",Initials="Db",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="106", Name = "Seaborgio",Initials="Sg",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="107", Name = "Bohrio",Initials="Bh",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="108", Name = "Hasio",Initials="Hs",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="109", Name = "Meitnerio",Initials="Mt",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="110", Name = "Darmstatio",Initials="Ds",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="111", Name = "Roentgenio",Initials="Rg",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="112", Name = "Copernicio",Initials="Cn",Category = CategorisEnum.BloqueD },
                new Elemento{ Id="113", Name = "Nihonio",Initials="Nh",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="114", Name = "Flerovio",Initials="Fl",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="115", Name = "Moscovio",Initials="Mc",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="116", Name = "Livermorio",Initials="Lv",Category = CategorisEnum.OtrosMetales },
                new Elemento{ Id="117", Name = "Teneso",Initials="Ts",Category = CategorisEnum.Halogenos },
                new Elemento{ Id="118", Name = "Oganeson",Initials="Og",Category = CategorisEnum.GasesNobles },
               
                new Elemento{ Id="57", Name = "Lantano",Initials="La",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="58", Name = "Cerio",Initials="Ce",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="59", Name = "Praseodimio",Initials="Pr",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="60", Name = "Neodimio",Initials="Nd",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="61", Name = "Prometio",Initials="Pm",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="62", Name = "Samario",Initials="Sm",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="63", Name = "Europio",Initials="Eu",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="64", Name = "Gadolinio",Initials="Gd",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="65", Name = "Terbio",Initials="Tb",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="66", Name = "Disprosio",Initials="Dy",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="67", Name = "Holmio",Initials="Ho",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="68", Name = "Erbio",Initials="Er",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="69", Name = "Tulio",Initials="Tm",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="70", Name = "Iterbio",Initials="Yb",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="71", Name = "Lutecio",Initials="Lu",Category = CategorisEnum.Lantanidos },
                new Elemento{ Id="89", Name = "Actinio",Initials="Ac",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="90", Name = "Torio", Initials="Th",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="91", Name = "Protactinio",Initials="Pa",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="92", Name = "Uranio",Initials="U",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="93", Name = "Neptunio",Initials="Np",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="94", Name = "Plutonio",Initials="Pu",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="95", Name = "Americio",Initials="Am",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="96", Name = "Curio",Initials="Cm",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="97", Name = "Berkelio",Initials="Bk",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="98", Name = "Californio",Initials="Cf",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="99", Name = "Einstenio",Initials="Es",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="100", Name = "Fermio",Initials="Fm",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="101", Name = "Mendelevio",Initials="Md",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="102", Name = "Nobelio",Initials="No",Category = CategorisEnum.Actinidos },
                new Elemento{ Id="103", Name = "Lawrencio",Initials="H",Category = CategorisEnum.Actinidos },
             
            };

            return elementos;
        }
    }
}