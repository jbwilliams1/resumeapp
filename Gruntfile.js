module.exports = function(grunt) {
  grunt.initConfig({
    less : {
      production : {
        options: {
          compress: true,
          yuicompress: false,
          optimization: 2,
          cleancss:false,  
          paths: ["src/ResumeApp/wwwroot/css/"],   
          syncImport: false,
          strictUnits:false,
          strictMath: true,
          strictImports: true,
          ieCompat: false    
        },
        files : {
          'src/ResumeApp/wwwroot/css/site.css' : 'src/ResumeApp/Assets/Less/site.less'
        }
      }
    },
    uglify : {
      options : {
        mangle : false
      },
      my_target : {
        files : {
          'src/ResumeApp/wwwroot/js/site.min.js' : ['node_modules/angular/angular.min.js', 'src/ResumeApp/Assets/JS/resume.js']
        }
      }
    }
  });


  grunt.registerTask('default', ['less:production', 'uglify']);

  grunt.loadNpmTasks('grunt-contrib-less');
  grunt.loadNpmTasks('grunt-contrib-uglify');
  // grunt.loadNpmTasks('grunt-contrib-copy');
};