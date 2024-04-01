function submitAction() {
    const userName = document.getElementById('userName').value;
    const arr = userName.split(" ");
    const userNo = document.getElementById('userNo').value;
    const userEmail = document.getElementById('userEmail').value;
    var userGender;
    if(document.getElementById('userMale').checked){
        userGender = "Male";
    }else if(document.getElementById('userFemale').checked){
        userGender = "Female";
    }
    const userBirthDate = document.getElementById('userBirthDate').value;
    const userPassword = document.getElementById('userPassword').value;
    const userAge = document.getElementById('userAge').value;
    const userState = document.getElementById('userState').value;
    var userLanguage = [];
    if(document.getElementById('java').checked==true){
        userLanguage.push("Java")
    }
    if(document.getElementById('c').checked==true){
        userLanguage.push("C")
    }
    if(document.getElementById('cpp').checked==true){
        userLanguage.push("C++")
    }
    if(document.getElementById('js').checked==true){
        userLanguage.push("JavaScript")
    }
    if(document.getElementById('cs').checked==true){
        userLanguage.push("C#")
    }
    if(document.getElementById('py').checked==true){
        userLanguage.push("Python")
    }
    const userAddress = document.getElementById('userAddress').value;
    console.log(userName);
    console.log(userNo);
    console.log(userEmail);
    console.log(userGender);
    console.log(userBirthDate);
    console.log(userPassword);
    console.log(userAge);
    console.log(userState);     
    console.log(userLanguage);
    console.log(userAddress);

    const msg = document.getElementById('msg');
    const showName = document.getElementById('showName'); 
    const showNumber = document.getElementById('showNumber'); 
    const showEmail = document.getElementById('showEmail'); 
    const showGender = document.getElementById('showGender'); 
    const showBirthDate = document.getElementById('showBirthDate'); 
    const showPassword = document.getElementById('showPassword'); 
    const showAge = document.getElementById('showAge'); 
    const showState = document.getElementById('showState'); 
    const showLanguage = document.getElementById('showLanguage'); 
    const showAddress = document.getElementById('showAddress'); 
    
    msg.innerHTML = `Hello ${arr[0]}, your data has been stored successfully`;
    showName.innerHTML = userName;
    showNumber.innerHTML = userNo;
    showEmail.innerHTML = userEmail;
    showGender.innerHTML = userGender;
    showBirthDate.innerHTML = userBirthDate;
    showPassword.innerHTML = userPassword;
    showAge.innerHTML = userAge;
    showState.innerHTML = userState;
    showLanguage.innerHTML = "";
    for (let i = 0; i < userLanguage.length; i++) {
        showLanguage.innerHTML += userLanguage[i]+", ";
    }
    showAddress.innerHTML = userAddress;
    const form = document.getElementById('form');
    hidePage();
}

function showPage() {
    console.log("helllo");
    const blurElement = document.getElementById('blur-element');
    const showData = document.getElementById('showData');
    blurElement.style.display = "none";
    showData.style.display = "none";
}

function hidePage(){
    const blurElement = document.getElementById('blur-element');
    const showData = document.getElementById('showData');
    blurElement.style.display = "block";
    showData.style.display = "flex";
}
