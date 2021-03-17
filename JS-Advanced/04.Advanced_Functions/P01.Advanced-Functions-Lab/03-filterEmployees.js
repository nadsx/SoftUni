function filterEmployees(data, criteria) { 
    console.log([...JSON.parse(data)
    .filter((el) => el[criteria.split('-')[0]] === criteria.split('-')[1])]
    .map((el, i) => `${i}. ${el["first_name"]} ${el["last_name"]} - ${el["email"]}`, 0)
    .join("\n"));
}

// Spread syntax:
// var obj1 = { foo: 'bar', x: 42 };
// var obj2 = { foo: 'baz', y: 13 };

// var clonedObj = { ...obj1 };
// // Обект { foo: "bar", x: 42 }

// var mergedObj = { ...obj1, ...obj2 };
// // Обект { foo: "baz", x: 42, y: 13 }

filterEmployees(`[{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  },  
{
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }]`,
    'gender-Female'
);

filterEmployees(`[{
    "id": "1",
    "first_name": "Kaylee",
    "last_name": "Johnson",
    "email": "k0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Johnson",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  }, {
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }, {
    "id": "4",
    "first_name": "Evanne",
    "last_name": "Johnson",
    "email": "ev2@hostgator.com",
    "gender": "Male"
  }]`,
    'last_name-Johnson'
);