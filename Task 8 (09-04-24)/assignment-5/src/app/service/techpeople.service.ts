import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TechpeopleService {
  techPeople: Array<any> = [
    {
      id: 1,
      name: "Cahaya Dewi",
      tech: "Digital Marketing",
      salary: 450000,
      img: "https://img.freepik.com/free-photo/young-male-curly-hair-isolated-colorful-shirt-one-finger_141793-30513.jpg?size=626&ext=jpg",
      poster: "https://marketplace.canva.com/EAFhefhKJOI/1/0/1600w/canva-white-minimalist-simple-marketing-expert-linkedln-banner-5_9hSGTGZy0.jpg",
      DOB: "23-02-2000",
      tagline: "Digital Marketing || Marketing Expert || Experience of 8 Years",
      address: "123 Maple Street, Suite 200, Springfield, IL 62704, United States. Near Springfield Park, opposite the Green Grocery Store.",
      company: "Spektra Systems",
      exp: 8
    },
    {
      id: 2,
      name: "Richard Sanchez",
      tech: "Content Marketing",
      salary: 200000,
      img: "https://img.freepik.com/premium-photo/portrait-young-happy-smiling-man-green-background-business-success-concept_994418-727.jpg?size=626&ext=jpg",
      poster: "https://marketplace.canva.com/EAFQfWzR-W8/1/0/1600w/canva-brown-transparent-minimalist-personal-profile-new-linkedin-banner-oxBsrxqM19U.jpg",
      DOB: "29-07-1993",
      tagline: "Content Marketing || SEO || Digital Marketing || Experience of 1+ Years",
      address: "456 Oak Avenue, Building B, Apartment 15A, Riverdale, GA 30296, United States. Next to the Riverdale Community Library, above the Oak Avenue Cafe.",
      company: "Spektra Systems",
      exp: 1
    
    },
    {
      id: 3,
      name: "Clara Williams",
      tech: "Java Developer",
      salary: 650000,
      img: "https://img.freepik.com/premium-photo/close-up-portrait-young-businessman_960782-25599.jpg?size=626&ext=jpg",
      poster: "https://marketplace.canva.com/EAE2cQaUHVA/1/0/1600w/canva-black-minimal-motivation-quote-linkedin-banner-HoRi-2buBWk.jpg",
      DOB: "13-03-1990",
      tagline: "Angular Developer || dot net Developer || learning attitude",
      address: "789 Pine Road, Lakeside Village, Unit 34, Lakeside, CA 92040, United States. Across from Lakeside High School, beside the Pine Grove Medical Center.",
      company: "Spektra Systems",
      exp: 4
    
    },
    {
      id: 4,
      name: "James Anderson",
      tech: ".Net Developer",
      salary: 550000,
      img: "https://img.freepik.com/premium-photo/young-boy-black-blank-tshirt-man-black-tshirt-ai-generated_1112329-27166.jpg?size=626&ext=jpg",
      poster: "https://marketplace.canva.com/EAFFI2trtnE/1/0/1600w/canva-black-minimalist-motivation-quote-linkedin-banner-cqVV-6-1kOk.jpg",
      DOB: "03-12-1987",
      tagline: "React Developer || SQL || MERN Stack || learning attitude",
      address: "1012 Birch Lane, Harmony Estates, 3rd Floor, Harmony, NY 13850, United States. Behind Harmony Shopping Mall, near the East River Bank.",
      company: "Spektra Systems",
      exp: 2
    },
    {
      id: 5,
      name: "Bartholomew Henderson",
      tech: "Back End Developer",
      salary: 850000,
      img: "https://img.freepik.com/free-photo/pleased-looking-camera-young-guy-student-wearing-backpack_141793-129483.jpg",
      poster: "https://marketplace.canva.com/EAE1234ciF8/1/0/1600w/canva-black-colorful-simple-futuristic-linkedin-banner-KLF4fKRaXX8.jpg",
      DOB: "11-11-1998",
      tagline: "C# Developer || .Net Developer || SQL || learning attitude",
      address: "345 Elm Court, Crestview Towers, Penthouse Suite, Crestview, FL 32536, United States. At the corner of Elm and Main, overlooking Central Park, adjacent to the Crestview Museum of Art.",
      company: "Spektra Systems",
      exp: 10
    }
  ]
}
