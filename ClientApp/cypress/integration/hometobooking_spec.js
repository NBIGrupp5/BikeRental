describe('Link to Booking form Test', function () {
    it('Clicks and asserts', function () {
        // Step 1. Arrange - setup initial app state
        // - visit a web page
        cy.visit('https://localhost:44334/')

        // - query for an element
        // Step 2. Act - take an action
        // - interact with the element
        cy.contains('Hyra').click()

        // Step 3. Assert - make an assertion
        // - make assertion about page content
        cy.url()
            .should('include', '/BookingForm')
    })
})