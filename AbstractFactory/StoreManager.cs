using System;
using System.Collections.Generic;
using BaseStoreModule;
using DaNangStore;
using HaNoiStore;
using HoChiMinhStore;

namespace StoreSystemLib {
    public class StoreManager {
        protected Dictionary<String, IStoreFactory> factories;

        public StoreManager() {
            this.factories = new Dictionary<string, IStoreFactory>();

            this.factories.Add("HaNoi", new HaNoiStoreFactory());
            this.factories.Add("DaNang", new DaNangStoreFactory());
            this.factories.Add("HoChiMinh", new HCMStoreFactory());
        }

        public IStoreFactory GetStore(string storeName) {
            try {
                var store = this.factories[storeName];
                Console.WriteLine($"Store at {storeName} is ready to serve ..."); 
                return store;
            } catch {
                Console.WriteLine("The store is not available");
                return null;
            }
        }
    }
}