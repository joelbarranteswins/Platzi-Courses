try {
    hello ();
} catch (error) {
    console.log(error);
    console.log('error catched by me');
}


try {
    anotherFn();
} catch {
    console.log("esto es un error")
}