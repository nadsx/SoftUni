function systemComponents(arr) {
    let systemComponents = new Map();

    for (const line of arr) {
        let items = line.split(" | ");
        let [system, component, subcomponent] = [items[0], items[1], items[2]];

        if (!systemComponents.get(system)) {
            systemComponents.set(system, new Map());
        }

        let setOfSubcomponent = systemComponents.get(system).get(component);

        if (!setOfSubcomponent) {
            systemComponents.get(system).set(component, []);
            setOfSubcomponent = systemComponents.get(system).get(component);
        }

        setOfSubcomponent.push(subcomponent);
    }

    console.log([...systemComponents]
        .sort((a, b) => b[1].size - a[1].size || a[0].localeCompare(b[0]))
        .map(system => `${system[0]}\n${[...system[1]].sort((a, b) => b[1].length - a[1].length)
                 .map(comp =>`|||${comp[0]}\n${[...comp[1]].map(subcomp =>`||||||${subcomp}`).join("\n")}`)
             .join("\n")}`) // N:2
        .join("\n"));
}

// N:2 Lambda|||CoreA // <== '}\n$' first
//||||||A23
//||||||A24
//||||||A25
//|||CoreB // <=== N:2 '.join("\n")' any other

systemComponents([
    'SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security'
]);