using ScarpeApp.Models;

namespace ScarpeApp.Models
{
    public static class Magazzino
    {
        private static List<Articolo> articoli = new List<Articolo>
        {
            
            new Articolo { Id = 1,
                Nome = "Campus 00's",
                Prezzo = 120.00m,
                Descrizione = "Stile classico e originale per la vita di tutti i giorni.",
                ImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/ce738cbe5342421996feaf5001044964_9366/Scarpe_Campus_00s_Grigio_HQ8707_01_standard.jpg",
                ImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/229d8cd3679f45f48e35af500104788e_9366/Scarpe_Campus_00s_Grigio_HQ8707_04_standard.jpg",
                ImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/de8448aed41b495c9ceeaf5001049ccf_9366/Scarpe_Campus_00s_Grigio_HQ8707_42_detail.jpg" },
          

            new Articolo { Id = 2,
                Nome = "Samba OG",
                Prezzo = 100.00m,
                Descrizione = "Stile comodo e sportivo per uso quotidiano.",
                ImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/d660e7a6bd5848b5888c9dd6b8e6f801_9366/Scarpe_Samba_OG_Bianco_JI2044_01_standard.jpg", 
                ImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/9957aacd07ab4e879237d63b18c6ae89_9366/Scarpe_Samba_OG_Bianco_JI2044_04_standard.jpg", 
                ImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/774c447251fe43868cca6c9d1d309849_9366/Scarpe_Samba_OG_Bianco_JI2044_09_standard.jpg" },

              new Articolo { Id = 3,
                Nome = "Handball Spezial", 
                Prezzo = 110.00m,
                Descrizione = "Scarpa sportiva casual, perfetta per tutti i giorni",
                ImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/caa08574a1fc456c8021219bd1edad5a_9366/Scarpe_Handball_Spezial_Beige_IF6562_01_standard.jpg", 
                ImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/12b883c4521c4c259b7002e0fcdcc80e_9366/Scarpe_Handball_Spezial_Beige_IF6562_04_standard.jpg", 
                ImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/5b8df30e3d7548d5837befee57b6b09f_9366/Scarpe_Handball_Spezial_Beige_IF6562_02_standard_hover.jpg" },

            new Articolo { Id = 4,
                Nome = "Stan Smith",
                Prezzo = 95.00m,
                Descrizione = "Lo stile intramontabile della semplicità.",
                ImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/69721f2e7c934d909168a80e00818569_9366/Scarpe_Stan_Smith_Bianco_M20324_01_standard.jpg",
                ImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/eb638fce8b4f4678b40aa80e00818f3a_9366/Scarpe_Stan_Smith_Bianco_M20324_04_standard.jpg",
                ImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/86ed42c633404d5fb377a6a500989c17_9366/Scarpe_Stan_Smith_Bianco_M20324_09_standard.jpg" },

            new Articolo { Id = 5,
                Nome = "Gazelle",
                Prezzo = 110.00m,
                Descrizione = "Stile vintage ed elegante, perfetto per tutti i giorni.",
                ImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/d059a37859e540e0a05ef26bbc9c8b35_9366/Scarpe_Gazelle_Indoor_Rosa_IH5484_01_standard.jpg",
                ImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/b0653ebec08849e5b32cf1d94cb94688_9366/Scarpe_Gazelle_Indoor_Rosa_IH5484_04_standard.jpg",
                ImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/647f53492f614d45b8a685809d4d9b24_9366/Scarpe_Gazelle_Indoor_Rosa_IH5484_09_standard.jpg" },

            new Articolo { Id = 6,
                Nome = "Grand Court Platform",
                Prezzo = 89.99m,
                Descrizione = "Stile innovativo, casual e originale.",
                ImmagineCopertina = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/f009131c7b3141e69d45a04333a2b12d_9366/Scarpe_Grand_Court_Platform_Bianco_IE3620_01_standard.jpg",
                ImmagineAggiuntiva1 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/6715e93596b14370b7ae91ce82f1e6d7_9366/Scarpe_Grand_Court_Platform_Bianco_IE3620_04_standard.jpg",
                ImmagineAggiuntiva2 = "https://assets.adidas.com/images/h_2000,f_auto,q_auto,fl_lossy,c_fill,g_auto/0818c42c8e77443dac2deb1c05ced17a_9366/Scarpe_Grand_Court_Platform_Bianco_IE3620_06_standard.jpg" },
        };

        public static List<Articolo> GetArticoli()
        {
            return articoli;
        }

        public static Articolo GetArticoloById(int id)
        {
            return articoli.Find(a => a.Id == id);
        }
    }
}
