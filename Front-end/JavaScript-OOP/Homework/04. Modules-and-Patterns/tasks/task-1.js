/* Task Description */

function solve() {


    var Course = {


        init: function (title, presentations) {

            if (title.search(/(^\s+)|(\s{2,})|(\s+$)/) > -1) {
                throw "Titles do not start or end with spaces and do not have consecutive spaces"
            }
            if (!title) {
                throw "Title is empty string";
            }
            if (title.length === 0) {
                throw "Titles have at least one character";
            }
            if (!presentations || presentations.length === 0) {
                throw "Throws if there are no presentations"
            }
            for (let presentation of presentations) {
                if (!presentation) {
                    throw "Throws if there is presentation not defined properly"
                }
            }
            if (presentations.some(function (p) {
                    return (typeof p) !== "string";
                })) {
                throw "Accepts an array of strings - presentation titles";
            }
            if (typeof title === "string") {
                this.title = title;
            }
            this.title = title;
            this.presentations = presentations;
            this.students = [];
            return this;
        },


        addStudent: function (name) {
            function checkIfNameIsValid(name) {
                if (!name) {
                    throw "Names is not defined";
                }
                let count = 0;
                name.split(' ').forEach(function (word) {
                    if (!word[0] || !word[0].match(/[A-Z]/)) {
                        throw "Names start with an upper case letter";
                    }
                    count += 1;
                    for (let i = 1; i < word.length; i += 1) {
                        if (!word[i].match(/[a-z]/)) {
                            throw "All other symbols in the name (if any) are lowercase letters"
                        }
                    }

                });
                if (count !== 2) {
                    throw "Name must contain two words"
                }

                return name;
            }

            let student = {
                name: name,
                studentID: this.students.length,
                homeworks: [],
                homeworkScore: 0,
                examScore: 0,
                totalScore: 0
            };

            if (typeof name !== "string") {
                throw "Accepts a string in the format 'Firstname Lastname'"
            }
            checkIfNameIsValid(name);
            this.students.push(student);
            return student.studentID;
        },


        getAllStudents: function () {
            let arrayOfStudents = [];
            for (let student of this.students) {
                let firstname = student.name.split(' ')[0],
                    lastname = student.name.split(' ')[1];
                var studentX = {
                    firstname: firstname,
                    lastname: lastname,
                    ID: arrayOfStudents.length + 1
                };
                arrayOfStudents.push(studentX);
            }
            return arrayOfStudents;
        },


        submitHomework: function (studentID, homeworkID) {
            if (!studentID || typeof studentID !== "number") {
                throw "Throws if studentID is invalid"
            }

            if (!homeworkID || typeof homeworkID !== "number") {
                throw "Throws if homeworkID is invalid"
            }
            if (homeworkID < 1 || homeworkID > this.presentations.length) {
                throw "Throws if homeworkID is invalid"
            }
            let studentHomeworks = this.students[studentID - 1].homeworks;
            if (!studentHomeworks.some(function alreadyExist(studentHomework, index, array) {
                    return studentHomework === homeworkID;
                })) {
                this.students[studentID - 1].homeworks.push(homeworkID);
            }
        },


        pushExamResults: function (results) {
            /*let args = arguments[0];*/
            let studentIDbank = [];
            for (let examResult of results) {
                if (!examResult.StudentID) {
                    examResult.score = 0;
                }
                if (typeof examResult.score !== "number") {
                    throw "	Throw if Score is not a number"
                }
                if (typeof examResult.StudentID !== 'number') {
                    throw "Throw if there is an invalid StudentID"
                }
                let occurrenceCheck = false;
                this.students.forEach(function (student) {
                    if (student.StudentID === examResult.StudentID) {
                        occurrenceCheck = true;
                    }
                });
                /*if (!occurrenceCheck) {
                 throw "Throw if there is an invalid StudentID"
                 }*/
                occurrenceCheck = false;
                if (studentIDbank.some(function (id) {
                        return id === examResult.StudentID
                    })) {
                    studentIDbank.push(examResult.StudentID);
                }
            }
            /*if (studentIDbank.length !== results.length) {
             throw "Throw if same StudentID is given more than once ( he tried to cheat (: )"
             }*/
            for (result of results) {
                let studentScore = 0;
                let homeworkScore = 0;
                this.students[result.StudentID - 1].examScore = result.score;
                studentScore = this.students[result.StudentID - 1].examScore;
                this.students[result.StudentID - 1].homeworkScore = this.students[result.StudentID - 1].homeworks.length * (25 / 3);
                homeworkScore = this.students[result.StudentID - 1].homeworkScore;
                this.students[result.StudentID - 1].totalScore = studentScore * 0.75 + homeworkScore;
            }
        },


        getTopStudents: function () {
            let arrayOfTopTen = this.students.sort(function (a, b) {
                return (b.totalScore) - (a.totalScore);
            });

            if (arrayOfTopTen.length > 10) {
                arrayOfTopTen.splice(10, arrayOfTopTen.length - 10)
            }
            return arrayOfTopTen;
        }
    };

    return Course;
}


module.exports = solve;
 let newCourse = solve();
 newCourse.init("OOP", ["one", "two", "three"]);
 console.log(newCourse.addStudent("Angel Angelov"));
 console.log(newCourse.addStudent("Petar Patrov"));
 console.log(newCourse.addStudent("Georgi Stefanov"));
 console.log(newCourse.getAllStudents());
 newCourse.submitHomework(1, 1);
 newCourse.submitHomework(1, 2);
 newCourse.submitHomework(1, 3);
 newCourse.pushExamResults([{StudentID: 1, score: 40}]);
 console.log(newCourse.students[0].name);
 console.log(newCourse.students[0].homeworkScore);
 console.log(newCourse.students[0].examScore);
 console.log(newCourse.students[0].totalScore);
 console.log('------------------------------------------------------');
 newCourse.submitHomework(2, 1);
 newCourse.submitHomework(2, 2);
 newCourse.pushExamResults([{StudentID: 2, score: 80}]);
 console.log(newCourse.students[1].name);
 console.log(newCourse.students[1].homeworkScore);
 console.log(newCourse.students[1].examScore);
 console.log(newCourse.students[1].totalScore);
 console.log('------------------------------------------------------');
 newCourse.submitHomework(3, 1);
 newCourse.pushExamResults([{StudentID: 3, score: 30}]);
 console.log(newCourse.students[2].name);
 console.log(newCourse.students[2].homeworkScore);
 console.log(newCourse.students[2].examScore);
 console.log(newCourse.students[2].totalScore);
 console.log('------------------------------------------------------');
 console.log('------------------------------------------------------');
 console.log(newCourse.getTopStudents());


