describe('My First Test', function () {
    it('Gets, types and asserts', function () {
        // Step 1. Arrange - setup initial app state
        // - visit a web page
        cy.visit('https://example.cypress.io')

        // - query for an element
        // Step 2. Act - take an action
        // - interact with the element
        cy.contains('type').click()

        // Step 3. Assert - make an assertion
        // - make assertion about page content
        cy.url()
            .should('include', '/commands/actions')

        cy.get('.action-email')// finds a css-class
            .type('my@email.com')//type text into selected input
            .should('have.value', 'my@email.com')// verify that the inputs value
                                                // is the same as the text that we typed
    })
})