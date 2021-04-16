var currentTab = 0; // Current tab is set to be the first tab (0)

function initializeComponent(container) {
    showTab(currentTab, container)
}

function showTab(n, container) {
    // This function will display the specified tab of the form ...
    var x = container.querySelectorAll(".tab");
    x[n].style.display = "block";
    // ... and fix the Previous/Next buttons:
    if (n == 0) {
        container.querySelector("#prevBtn").style.display = "none";
    } else {
        container.querySelector("#prevBtn").style.display = "inline";
    }
    if (n == (x.length - 1)) {
        container.querySelector("#nextBtn").innerHTML = 'Dalej';
    } else {
        container.querySelector("#nextBtn").innerHTML = 'Dalej';
    }
    // ... and run a function that displays the correct step indicator:
    fixStepIndicator(n, container)
}

function nextPrev(n, container) {
    // This function will figure out which tab to display
    var x = container.querySelectorAll(".tab");
    // Exit the function if any field in the current tab is invalid:
    if (n == 1 && !validateForm(container)) return false;
    // Hide the current tab:
    x[currentTab].style.display = "none";
    // Increase or decrease the current tab by 1:
    currentTab = currentTab + n;
    // if you have reached the end of the form... :
    if (currentTab >= x.length) {
        //...the form gets submitted:
        container.querySelector("#nextprevious").style.display = "none";
        container.querySelector("#all-steps").style.display = "none";
        container.querySelector("#register").style.display = "none";
        container.querySelector("#text-message").style.display = "block";
        container.querySelector("regForm").submit();
        return false;
    }
    // Otherwise, display the correct tab:
    showTab(currentTab, container);
}

function validateForm(container) {
    // This function deals with validation of the form fields
    var x, y, i, valid = true;
    x = container.querySelectorAll(".tab");
    y = x[currentTab].querySelectorAll("input");
    // A loop that checks every input field in the current tab:
    for (i = 0; i < y.length; i++) {
        // If a field is empty...
        if (y[i].value == "") {
            // add an "invalid" class to the field:
            y[i].className += " invalid";
            // and set the current valid status to false:
            valid = false;
        }
    }
    // If the valid status is true, mark the step as finished and valid:
    if (valid) {
        container.querySelectorAll(".step")[currentTab].className += " finish";
    }
    return valid; // return the valid status
}

function fixStepIndicator(n, container) {
    // This function removes the "active" class of all steps...
    var i, x = container.querySelectorAll(".step");
    for (i = 0; i < x.length; i++) {
        x[i].className = x[i].className.replace(" active", "");
    }
    //... and adds the "active" class to the current step:
    x[n].className += " active";
}
