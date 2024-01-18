
const users = {
    gndx: {
        country: "MX"
    },
    ana: {
        country: "CO"
    }
}
console.log(users.gndx.country);
console.log(users?.developer?.country || 'no existe esa información');