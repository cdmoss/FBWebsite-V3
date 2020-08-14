﻿let originalEntryValues;

function makeEntryEditable(id) {

    originalEntryValues = {
        volunteer: document.getElementById("entry-volunteer-" + id).value,
        position: document.getElementById("entry-position-" + id).value,
        date: document.getElementById("entry-date-" + id).value,
        start: document.getElementById("entry-starttime-" + id).value,
        end: document.getElementById("entry-endtime-" + id).value
    }

    let volunteerField = document.getElementById("entry-volunteer-" + id);
    let positionField = document.getElementById("entry-position-" + id);
    let dateField = document.getElementById("entry-date-" + id);
    let startField = document.getElementById("entry-starttime-" + id);
    let endField = document.getElementById("entry-endtime-" + id);

    let entryFields = [];

    entryFields.push(volunteerField);
    entryFields.push(positionField);
    entryFields.push(dateField);
    entryFields.push(startField);
    entryFields.push(endField);

    entryFields.forEach(function (field) {
        if (field.nodeName == "INPUT") {
            field.readOnly = false;
        }
        if (field.nodeName == "SELECT") {
            field.disabled = false;
        }

        field.classList.add("being-edited");
    })

    let unselectedButtons = Array.from(document.getElementsByClassName("unselected-buttons"));

    unselectedButtons.forEach(function (buttonGroup) {
        buttonGroup.style.display = "none";
    })

    document.getElementById("entry-selected-" + id).style.display = "inline-flex";
}

function cancelEntryEdit(id) {

    let entryFields = Array.from(document.getElementsByClassName("being-edited"));

    entryFields.forEach(function (field) {
        if (field.nodeName == "INPUT") {
            field.readOnly = false;
        }
        if (field.nodeName == "SELECT") {
            field.disabled = false;
        }

        field.classList.remove("being-edited");
    })

    document.getElementById("entry-volunteer-" + id).value = originalEntryValues.volunteer;
    document.getElementById("entry-position-" + id).value = originalEntryValues.position
    document.getElementById("entry-date-" + id).value = originalEntryValues.date;
    document.getElementById("entry-starttime-" + id).value = originalEntryValues.start;
    document.getElementById("entry-endtime-" + id).value = originalEntryValues.end;

    let unselectedButtons = Array.from(document.getElementsByClassName("unselected-buttons"));

    unselectedButtons.forEach(function (button) {
        button.style.display = "inline-flex";
    })

    document.getElementById("entry-selected-" + id).style.display = "none";
}