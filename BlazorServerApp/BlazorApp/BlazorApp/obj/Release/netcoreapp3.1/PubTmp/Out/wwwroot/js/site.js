function saveMessage(firstName, lastName) {
    //alert(firstName + ' ' + lastName + ' has been saved successfully!');

    document.getElementById('divServerValidations').innerText = firstName + ' ' + lastName + ' has been saved successfully!';
}

function setFocusOnElement(element) {
    element.focus();
}

function getCities() {    

    //throw 'Something has gone wrong JS';

    var cities = ['New York', 'Los Angeles', 'Chicago', 'Houston', 'Phoenix', 'Philadelphia', 'San Antonio',
        'San Diego', 'Dallas', 'San Jose', 'Austin', 'Jacksonville', 'Fort Worth', 'Columbus', 'San Francisco',
        'Charlotte', 'Indianapolis', 'Seattle', 'Denver', 'Washington'];
    return cities;
}
