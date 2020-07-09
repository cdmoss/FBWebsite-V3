﻿// open shifts
function setShiftAsOpenAdd() {
    var markedAsOpen = $('#open-shift-add').prop('checked');
    var volunteerContainer = document.getElementById('volunteer-container-add');
    var volunteerField = document.getElementById('add-shift-volunteer');
    if (markedAsOpen == true) {
        volunteerField.disabled = true;
        volunteerContainer.style.display = "none";
    } else {
        volunteerField.disabled = false;
        volunteerContainer.style.display = "inline";
    }
}

function setShiftAsOpenEdit() {
    var markedAsOpen = $('#open-shift-edit').prop('checked');
    var volunteerContainer = document.getElementById('volunteer-container-edit');
    var volunteerField = document.getElementById('edit-shift-volunteer');
    if (markedAsOpen == true) {
        volunteerField.disabled = true;
        volunteerContainer.style.display = "none";
    } else {
        volunteerField.disabled = false;
        volunteerContainer.style.display = "inline";
    }
}

function setRecurringShiftAsOpen() {
    var markedAsOpen = $('#open-shift-edit-rec').prop('checked');
    var volunteerContainer = document.getElementById('volunteer-container-edit-rec');
    var volunteerField = document.getElementById('edit-recshift-volunteer');
    if (markedAsOpen == true) {
        volunteerField.disabled = true;
        volunteerContainer.style.display = "none";
    } else {
        volunteerField.disabled = false;
        volunteerContainer.style.display = "inline";
    }
}

// for changing the modal display based on recurring shift checkbox
function toggleAddRecurringShiftControls() {
    if ($("#add-recshift-display").prop("checked") == true) {
        // shows recurring shift controls
        $('#add-recshift-container').prop('style', 'display: block');
        // shows add recurring shift button, hides add shift button
        $('#add-recshift-submit').prop('style', 'display: block');
        $('#add-shift-submit').prop('style', 'display: none');
        $('#add-recshift-enddate').prop('required', true);
    }
    else if ($("#add-recshift-display").prop("checked") == false) {
        // hides recurring shift controls
        $('#add-recshift-container').prop('style', 'display: none');
        // hides add recurring shift button, shows add shift button
        $('#add-recshift-submit').prop('style', 'display: none');
        $('#add-shift-submit').prop('style', 'display: block');
        $('#add-recshift-enddate').prop('required', false);
    }
}

function toggleEditRecurringShiftControls() {
    var markedAsSelectedShift = $('#edit-recshift-display-single').prop('checked');
    var startDateLabel = document.getElementById('edit-recshift-startdate-label');
    if (markedAsSelectedShift) {
        $('#edit-recshift-container').prop('style', 'display: none');
        $('#edit-recshift-single-final-startdate').prop('style', 'display: block');
        $('#edit-recshift-all-startdate').prop('style', 'display: none');
        $('#edit-recshift-enddate').prop('required', false);

        startDateLabel.innerHTML = "Selected Shift Date"
    }
    else if (markedAsSelectedShift == false) {
        $('#edit-recshift-container').prop('style', 'display: block');
        $('#edit-recshift-single-final-startdate').prop('style', 'display: none');
        $('#edit-recshift-all-startdate').prop('style', 'display: block');
        $('#edit-recshift-enddate').prop('required', true);

        startDateLabel.innerHTML = "Recurring Shift Start Date"
    }
}