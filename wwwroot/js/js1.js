document.addEventListener("DOMContentLoaded", function () {
    const eventForm = document.getElementById("post-event-form");

    if (eventForm) {
        eventForm.addEventListener("submit", function (event) {
            event.preventDefault(); // Prevent the default form submission

            // Basic form validation
            if (!eventForm.checkValidity()) {
                alert("Please fill out all required fields correctly.");
                return;
            }

            // Display an alert showing the submitted event details
            const eventName = document.getElementById("event-name").value;
            const eventDate = document.getElementById("event-date").value;
            const eventTime = document.getElementById("event-time").value;
            const eventCategory = document.getElementById("event-category").value;

            alert(`Event Submitted Successfully!\n\nEvent Name: ${eventName}\nEvent Date: ${eventDate}\nEvent Time: ${eventTime}\nEvent Category: ${eventCategory}`);

            // Reset the form fields
            eventForm.reset();
        });
    }


    const contactForm = document.getElementById("contact-form");

    if (contactForm) {
        contactForm.addEventListener("submit", function (event) {
            event.preventDefault(); // Prevent the default form submission

            // Basic form validation
            if (!contactForm.checkValidity()) {
                alert("Please fill out all required fields correctly.");
                return;
            }

            // Display an alert showing the submitted contact details
            const contactName = document.getElementById("name").value;
            const contactEmail = document.getElementById("email").value;
            const contactMessage = document.getElementById("message").value;

            alert(`Contact Form Submitted Successfully!\n\nName: ${contactName}\nEmail: ${contactEmail}\nMessage: ${contactMessage}`);

            // Reset the form fields
            contactForm.reset();
        });
    }
});
