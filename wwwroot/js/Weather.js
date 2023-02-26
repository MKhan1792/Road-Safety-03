const temeratureField = document.querySelector(".temp")
const locationFild = document.querySelector(".time_location p")
const dataandtimeField = document.querySelector(".time_location span")
const conditionFild = document.querySelector(".condition p")
const searchFild = document.querySelector("search_area")
const form = document.querySelector("form")
let target = 'Rajkot'

const fetchResult = async (targetLocation)=>{
    let URL = `http://api.weatherapi.com/v1/current.json?key=ef56406f6f604d31bf8235511232502&q=${targetLocation}&aqi=no`

    const res = await fetch(URL);

    const data = res.json();
    console.log(data)

    let locationName = data.location.name
    let time = data.location.localtime

    let temp = data.current.temp_c

    let condition = data.current.condition.text

    updateDetails(temp,locationName,time,condition)
}

function updateDetails(temp,locationName,time,condition){
    let splitDate = time.split(' ')[0]
    let splitTime = time.split(' ')[1]

    let currentDay = getDayNane(new Date(splitDate).getDay())

    document.write(temp)
    document.getElementById("demo").value = temp;
    locationFild.innerHTML = locationName
    dataandtimeField.innerHTML = `${splitDate} ${currentDay} ${splitTime}`
    conditionFild.innerHTML = condition
}

function searchForLocation(e) {
    e.preventDefult();

    target = document.getElementById("Search_v").value;

    fetchResult(target)
}

function getDayNane(number)
{
    switch(number){
        case 0:
            return 'Sunday'
        case 1:
            return 'Monday'
        case 2:
            return 'Tuesday'
        case 3:
            return 'Wednusday'
        case 4:
            return 'Thursday'
        case 5:
            return 'Friday'
        case 6:
            return 'Saturday'
    }
}

fetchResult(target);