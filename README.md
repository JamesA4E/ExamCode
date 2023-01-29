While this Markdown file can be found in the project directory itself, it has been included as an appendix to this document for sake of comprehensiveness.

### Live Instance

A live instance of the admin interface can be found at: [https://examcode.mrjjones.co.uk](https://examcode.mrjjones.co.uk/)

The installation EXE can be compiled from code found on the github repository: XX

### Deployment

#### Academic Hand-in Specific

If you are accessing ExamCode via the live instance above for academic purposes then the web interface should already be configured, any issues you run into please contact [james.j01@gmail.com](mailto:james.j01@gmail.com).

To access the learner interface please pull the C# repository from github, this will contain a compiled exe file that can be run along with the source files to show what the program will do.

#### Installation

Due to the nature of this project the admin interface cannot simply be installed by a user, it requires a link between a school's MIS and the settings section via Wonde API.

If you are a network admin / exams office wishing to use this system in you school then please contact [james.j01@gmail.com](mailto:james.j01@gmail.com) to arrange a demonstration. After the demonstration takes place, if you wish to use the system then James will contact Wonde and arrange the connection between the system and your schools MIS.

#### Directories

The directory listings are as follow:

- App – CodeIgniter application file.
- App/Config – configuration files used by CodeIgniter including files such as:
  - php – main settings for the CodeIgniter application.
  - php – database connection settings.
  - php – static paths used within the MCV project.
- App/Controllers - Controller files used within the Controller section of the MCV.
- App/Models – database models files used withing the Model section of the MCV.
- App/Views – View php files used to render the view to the end user.
- Public\_html – publicly facing html files containing css and js library files.
- System – main CodeIgniter system files.
- Writeable – secure non publicly facing upload point used within CodeIgniter.

#### License

MIT