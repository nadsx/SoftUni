const BookStore = require('./02-BookStore.js');

const expect = require('chai').expect;

describe('Test class BookStore', () => {
    let bookStore;

    beforeEach(function () {
        bookStore = new BookStore('Store');
    });

    describe('Test Constructor', () => {
        it('Test Properties', () => {
            expect(bookStore.name).to.equal('Store');
            expect(bookStore.books).to.deep.equal([]);
            expect(bookStore.workers).to.deep.equal([]);
        });
    });

    describe('Test stockBooks()', () => {
        it('Test adding book', () => {
            const result = bookStore.stockBooks(['Harry Potter-J.Rowling']);

            expect(result).to.deep.equal([{
                title: "Harry Potter",
                author: "J.Rowling"
            }]);
            expect(bookStore.books.length).to.equal(1);
            expect(bookStore.books[0]).to.deep.equal({
                title: "Harry Potter",
                author: "J.Rowling"
            });
        });
    });

    describe('Test hire()', () => {
        it('Test error message', () => {
            bookStore.hire('George', 'seller');
            const result = () => bookStore.hire('George', 'seller');

            expect(result).to.throw(Error, 'This person is our employee');
        });

        it('Test functionality', () => {
            const result = bookStore.hire('George', 'seller');

            expect(result).to.equal('George started work at Store as seller');
            expect(bookStore.workers.length).to.equal(1);
            expect(bookStore.workers[0]).to.deep.equal({
                name: 'George',
                position: 'seller',
                booksSold: 0
            });
        });
    });

    describe('Test fire()', () => {
        it('Test error', () => {
            const result = () => bookStore.fire('George');

            expect(result).to.throw(Error, "George doesn't work here");
        });

        it('Test functionality', () => {
            bookStore.hire('George', 'seller');
            const result = bookStore.fire('George');

            expect(result).to.equal('George is fired');
            expect(bookStore.workers.length).to.equal(0);
            expect(bookStore.workers[0]).not.deep.equal({
                name: 'George',
                position: 'seller',
                booksSold: 0
            });
        });
    });

    describe('Test sellBook()', () => {
        it('Test invalid book error', () => {
            const result = () => bookStore.sellBook('ErrorBook', 'ErrorWorker');

            expect(result).to.throw(Error, 'This book is out of stock');
        });

        it('Test invalid worker error', () => {
            bookStore.stockBooks(['Harry Potter-J.Rowling']);
            const result = () => bookStore.sellBook('Harry Potter', 'Error');

            expect(result).to.throw(Error, 'Error is not working here');
        });

        it('Test functionality', () => {
            bookStore.stockBooks(['Harry Potter-J.Rowling']);
            bookStore.hire('George', 'seller');
            bookStore.sellBook('Harry Potter', 'George');

            expect(bookStore.books.length).to.equal(0);
            expect(bookStore.workers[0]).to.deep.equal({
                name: 'George',
                position: 'seller',
                booksSold: 1
            });
        });
    });

    describe('Test printWorkers()', () => {
        it('Test functionality', () => {
            bookStore.hire('George', 'seller');
            const result = bookStore.printWorkers();

            expect(result).to.equal('Name:George Position:seller BooksSold:0');
        });
    });
});