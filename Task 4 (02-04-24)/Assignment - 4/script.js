let arr = [90,78,87,95,99];

let sum = 0;
for(i of arr){
    sum += i;
}
console.log(`sum of array is ${sum}`);

let avg = sum/arr.length;
console.log(`Average of array is ${avg}`);

let percent = (sum*100)/(100*arr.length);
let grade;

if(percent>=91 && percent<=100){
    grade = 'A';
}
else if(percent>=81 && percent<=90){
    grade = 'B';
}
else if(percent>=71 && percent<=80){
    grade = 'C';
}
else{
    grade = 'D';
}
console.log(`Your grade is ${grade}`);