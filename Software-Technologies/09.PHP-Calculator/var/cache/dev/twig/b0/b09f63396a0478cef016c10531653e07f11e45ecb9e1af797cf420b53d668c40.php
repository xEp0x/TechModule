<?php

/* form/fields.html.twig */
class __TwigTemplate_ec9c5d81e39020694d3b6b736e1f6f92caaef22c4e9e543e4509e3575946054f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'date_time_picker_widget' => array($this, 'block_date_time_picker_widget'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_73d17767f954bffe985091b514cf0c07cebb3cbc60c6d0da25f6e9c3144005f5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_73d17767f954bffe985091b514cf0c07cebb3cbc60c6d0da25f6e9c3144005f5->enter($__internal_73d17767f954bffe985091b514cf0c07cebb3cbc60c6d0da25f6e9c3144005f5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "form/fields.html.twig"));

        // line 9
        echo "
";
        // line 10
        $this->displayBlock('date_time_picker_widget', $context, $blocks);
        
        $__internal_73d17767f954bffe985091b514cf0c07cebb3cbc60c6d0da25f6e9c3144005f5->leave($__internal_73d17767f954bffe985091b514cf0c07cebb3cbc60c6d0da25f6e9c3144005f5_prof);

    }

    public function block_date_time_picker_widget($context, array $blocks = array())
    {
        $__internal_f2c624a82143da4a9b35dc8287ba78a975e6ecc3e2d4f588a255ceaef7a99b3c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f2c624a82143da4a9b35dc8287ba78a975e6ecc3e2d4f588a255ceaef7a99b3c->enter($__internal_f2c624a82143da4a9b35dc8287ba78a975e6ecc3e2d4f588a255ceaef7a99b3c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "date_time_picker_widget"));

        // line 11
        echo "    ";
        ob_start();
        // line 12
        echo "        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            ";
        // line 13
        $this->displayBlock("datetime_widget", $context, $blocks);
        echo "
            ";
        // line 15
        echo "                ";
        // line 16
        echo "            ";
        // line 17
        echo "        </div>
    ";
        echo trim(preg_replace('/>\s+</', '><', ob_get_clean()));
        
        $__internal_f2c624a82143da4a9b35dc8287ba78a975e6ecc3e2d4f588a255ceaef7a99b3c->leave($__internal_f2c624a82143da4a9b35dc8287ba78a975e6ecc3e2d4f588a255ceaef7a99b3c_prof);

    }

    public function getTemplateName()
    {
        return "form/fields.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  52 => 17,  50 => 16,  48 => 15,  44 => 13,  41 => 12,  38 => 11,  26 => 10,  23 => 9,);
    }

    public function getSource()
    {
        return "{#
   Each field type is rendered by a template fragment, which is determined
   by the name of your form type class (DateTimePickerType -> date_time_picker)
   and the suffix \"_widget\". This can be controlled by overriding getBlockPrefix()
   in DateTimePickerType.

   See http://symfony.com/doc/current/cookbook/form/create_custom_field_type.html#creating-a-template-for-the-field
#}

{% block date_time_picker_widget %}
    {% spaceless %}
        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            {{ block('datetime_widget') }}
            {#<span class=\"input-group-addon\">#}
                {#<span class=\"fa fa-calendar\" aria-hidden=\"true\"></span>#}
            {#</span>#}
        </div>
    {% endspaceless %}
{% endblock %}
";
    }
}
