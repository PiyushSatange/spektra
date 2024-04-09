import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MedicineService {
  medicine: Array<any> = [
    {mid:1, mtitle:"Liver Detox", mdetails:"Gynoveda Liver Detox Ayurvedic Supplement Beneficial For Fatty Liver Kutki + 12 Herbs Helps Reduce Damage Caused By Alcohol, Allopathic Medicines, Pack of 1", msrc:"https://m.media-amazon.com/images/I/71VwhtBADQL._SX679_.jpg", mrating:4, price:2500},
    {mid:2, mtitle:"Hyper Care", mdetails:"Sheopal's Hyper Care High Blood Pressure Capsule For Hypertension Management | High BP Control Ayurvedic Medicine | Hypertension Relief - 60 Capsule", msrc:"https://m.media-amazon.com/images/I/61GvVmY+z+L._SX679_.jpg", mrating:3, price:1240},
    {mid:3, mtitle:"Multani Pachmeena", mdetails:"Multani Pachmeena Kabz Down Granules | Ayurvedic Constipation Relief Medicine | For Digestive Issue, Stomach-Ache & Flatulence | Acidity, Gas & Bloating | Promotes Healthy Bowel Movement | 60 Gm", msrc:"https://m.media-amazon.com/images/I/61ssHYI2e1L._SX679_.jpg", mrating:4, price:400},
    {mid:4, mtitle:"AVP Haridrakhandam", mdetails:"AVP Haridrakhandam 150g | Allergy Rakshak | Ayurvedic Medicine With Strength of Turmeric, Amla and Ela | Cold and Cough | Skin Allergies | Boosts Natural Immunity | No Preservatives | No Chemicals", msrc:"https://m.media-amazon.com/images/I/81MccwswWaL._SX679_.jpg", mrating:5, price:800},
    {mid:5, mtitle:"Dabur Tulsi Drops", mdetails:"Dabur Tulsi Drops : 30ml (20ml + 10ml Free) | Contains Extracts of 5 Rare Tulsi | Boosts Immunity | Cough And Cold Relief | 100% Ayurvedic | Builds Respiratory Health", msrc:"https://m.media-amazon.com/images/I/711BtjiDpxL._SX679_.jpg", mrating:3, price:120},
    {mid:6, mtitle:"DABUR Arjuna Tablets", mdetails:"DABUR Arjuna Tablets - 60 Tabs | Promotes Heart Health | Manages Cholesterol Level | Promotes Healthy Metabolism,Pack of 1", msrc:"https://m.media-amazon.com/images/I/71HsoGKgeXL._SX679_.jpg", mrating:4, price:550}
  ]
}
