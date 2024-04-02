for(let year=2014; year<=2050; year++){
    let d = new Date(year, 0, 1);
    if(d.getDay() == 0){
        console.log(`1st january is being a sunday ${year}`);
    }
}