class User {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    showInfo() {
        console.log(`User: ${this.name}, Age: ${this.age}`);
    }

    get userAge() {
        return this.age;
    }

    set userAge(age) {
        this.age = age;
    }
}


const user = new User('Juan', 25);
user.showInfo();
console.log(user.userAge);
console.log(user.userAge = 26);

console.log(user.showInfo());